using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TextEditor
{
    public partial class FDictionary : Form
    {
        Dictionary<string, Color> dictionary;
        int selectedWord = -1;
        ContextMenuStrip cms;

        public FDictionary(Dictionary<string, Color> dictionary, string title = "Dictionary")
        {
            InitializeComponent();

            this.Text = title;
            this.dictionary = new Dictionary<string, Color>();
            cms = new ContextMenuStrip();

            if (dictionary == null || dictionary.Count == 0)
                return;

            for (int i = 0; i < dictionary.Count; i++)
                this.dictionary.Add(dictionary.ElementAt(i).Key , dictionary.ElementAt(i).Value);
        }

        private void FDictionary_Load(object sender, System.EventArgs e)
        {
            UpdatePBColor(Color.Black);

            cms.Items.Add("Edit").Tag = 0;
            cms.ItemClicked += Cms_ItemClicked;

            if (dictionary == null || dictionary.Count == 0)
                return;

            var words = dictionary.Select(w => w.Key).ToArray();
            LB_Main.Items.AddRange(words);
        }

        private void Cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch((int)e.ClickedItem.Tag)
            {
                case 0:
                    {
                        string key = dictionary.ElementAt(selectedWord).Key;
                        FTextEdit form = new FTextEdit(key);
                        form.ShowDialog();
                        if (form.Tag == null)
                            return;

                        string newName = form.Tag.ToString();
                        var keys = dictionary.Select(w => w.Key).ToList();
                        if (keys.Contains(newName))
                        {
                            MessageBox.Show(string.Format("Word \"{0}\" already exist", newName), "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                        Color color = dictionary[key];
                        dictionary.Remove(key);
                        dictionary.Add(newName, color);
                        UpdateWordList();

                        break;
                    }
            }
        }

        private void LB_Main_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            selectedWord = LB_Main.SelectedIndex;

            if (selectedWord >= 0 && selectedWord < dictionary.Count)
                UpdatePBColor(dictionary.ElementAt(selectedWord).Value);
        }

        private void LB_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cms.Show(Cursor.Position);
        }

        private void B_Add_Click(object sender, System.EventArgs e)
        {
            FTextEdit form = new FTextEdit(null);
            form.ShowDialog();
            if (form.Tag == null)
                return;
            
            string newName = form.Tag.ToString();
            var keys = dictionary.Select(w => w.Key).ToList();
            if (keys.Contains(newName))
            {
                MessageBox.Show(string.Format("Word \"{0}\" already exist", newName), "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dictionary.Add(newName, Color.Black);
            UpdateWordList();
        }

        private void B_Delete_Click(object sender, System.EventArgs e)
        {
            if (selectedWord < 0)
                return;

            string key = dictionary.ElementAt(selectedWord).Key;
            DialogResult dr = MessageBox.Show(string.Format("Delete \"{0}\"?", key), "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                dictionary.Remove(key);
                selectedWord--;
                UpdateWordList();
            }
        }

        private void UpdateWordList()
        {
            LB_Main.Items.Clear();

            LB_Main.Items.AddRange(dictionary.Select(w => w.Key).ToArray());
            LB_Main.SelectedIndex = LB_Main.Items.Count - 1;
        }

        private void PB_Color_Click(object sender, System.EventArgs e)
        {
            if (selectedWord < 0)
                return;

            string key = dictionary.ElementAt(selectedWord).Key;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = dictionary.ElementAt(selectedWord).Value;
            colorDialog.ShowDialog();
            Color newColor = colorDialog.Color;
            dictionary[key] = newColor;
            UpdatePBColor(newColor);
        }

        private void B_Close_Click(object sender, System.EventArgs e)
        {
            this.Tag = dictionary;
            Close();
        }

        private void B_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void UpdatePBColor(Color color)
        {
            PB_Color.BackColor = color;
            PB_Color.Invalidate();
        }
    }
}
