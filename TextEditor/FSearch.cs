using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class FSearch : Form
    {
        RichTextBox rtb;
        string inputText;
        bool caseSensitive = false;

        public FSearch(RichTextBox rtb, string text)
        {
            InitializeComponent();
            this.rtb = rtb;
            this.inputText = text;
        }

        private void FSearch_Load(object sender, EventArgs e)
        {
            if (inputText == null || inputText == "")
                return;

            TB_SearchText.Text = inputText;
        }

        private void FSearch_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        this.Close();
                        break;
                    }
            }
        }

        private void B_Find_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void B_Replace_Click(object sender, EventArgs e)
        {
            bool sucsessfully = Search();

            if (sucsessfully)
            {
                string newText = TB_NewText.Text;
                rtb.SelectedText = newText;
            }
        }

        private void B_ReplaceAll_Click(object sender, EventArgs e)
        {
            string word = caseSensitive ? TB_SearchText.Text : TB_SearchText.Text.ToLower();
            string replaceWord = TB_NewText.Text;
            string textTemp = caseSensitive ? rtb.Text : rtb.Text.ToLower();
            int selectionStart = 0;
            int counter = 0;

            while (textTemp.Contains(word))
            {
                counter++;

                int begin = textTemp.IndexOf(word);
                rtb.SelectionStart = begin + selectionStart;
                rtb.SelectionLength = word.Length;
                rtb.SelectedText = replaceWord;

                selectionStart = begin + replaceWord.Length;
                textTemp = caseSensitive ? rtb.Text.Substring(selectionStart) : rtb.Text.Substring(selectionStart).ToLower();
            }

            rtb.SelectionStart = rtb.SelectionLength = 0;
            MessageBox.Show(string.Format("Replaced matches: {0}", counter), "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void B_CountMatches_Click(object sender, EventArgs e)
        {
            string word = caseSensitive ? TB_SearchText.Text : TB_SearchText.Text.ToLower();
            string textTemp = caseSensitive ? rtb.Text : rtb.Text.ToLower();
            int selectionStart = 0;
            int counter = 0;

            while (textTemp.Contains(word))
            {
                counter++;

                int begin = textTemp.IndexOf(word);
                
                selectionStart = begin + word.Length;
                textTemp = caseSensitive ? textTemp.Substring(selectionStart) : textTemp.Substring(selectionStart).ToLower();
            }

            MessageBox.Show(string.Format("Matches found: {0}", counter), "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CB_CaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            caseSensitive = CB_CaseSensitive.Checked;
        }

        private bool Search(bool repeated = false)
        {
            int selectionStart = rtb.SelectionStart + rtb.SelectionLength;
            string textTemp = caseSensitive ? rtb.Text.Substring(selectionStart) : rtb.Text.Substring(selectionStart).ToLower();
            string word = caseSensitive ? TB_SearchText.Text : TB_SearchText.Text.ToLower();
            if (textTemp.Contains(word))
            {
                int begin = textTemp.IndexOf(word);
                rtb.SelectionStart = begin + selectionStart;
                rtb.SelectionLength = word.Length;
                this.Owner.Focus();
                return true;
            }
            else
            {
                if (!repeated)
                {
                    DialogResult dr = MessageBox.Show(string.Format("Could not find text \"{0}\"\n\nStart from the beginning?", word),
                    "Text Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        rtb.SelectionStart = 0;
                        rtb.SelectionLength = 0;
                        if (Search(true))
                            return true;
                    }
                }
                else
                    MessageBox.Show(string.Format("Could not find text \"{0}\"", word), "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }
    }
}
