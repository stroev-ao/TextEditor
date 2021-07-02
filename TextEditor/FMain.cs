using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;

namespace TextEditor
{
    public partial class FMain : Form
    {
        Controller controller;
        Timer timer;
        bool initialization = false, fileChanged = false;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;

        public FMain()
        {
            InitializeComponent();

            controller = new Controller();
            timer = new Timer()
            {
                Interval = 500
            };
            timer.Tick += Timer_Tick;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            RTB_Main.SelectionTabs = new int[] { 25, 50, 75, 100, 125, 150, 175, 200, 225, 250, 275, 300,
                325, 350, 375, 400, 425, 450, 475, 500, 525, 550, 575, 600, 625, 650, 675, 700 };
            RTB_Main.Font = controller.GetFont();
            RTB_Main.BackColor = controller.GetBackColor();
            RTB_Main.ForeColor = controller.GetTextColor();
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileChanged)
            {
                DialogResult dr = MessageBox.Show("Save changes?", "Text Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            SaveFile();
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            initialization = true;

            Dictionary<string, Color> dictionary = controller.GetDictionary();
            string text = RTB_Main.Text;

            int caretePosition = RTB_Main.SelectionStart;

            //останавливаем обновление
            SendMessage(RTB_Main.Handle, WM_SETREDRAW, false, 0);

            RTB_Main.SelectAll();
            RTB_Main.SelectionColor = controller.GetTextColor();

            for (int i = 0; i < dictionary.Count; i++)
            {
                string word = dictionary.ElementAt(i).Key;
                string tempText = text.ToLower();
                int offset = 0;

                while (true)
                {
                    if (tempText.Contains(word))
                    {
                        int begin = tempText.IndexOf(word);

                        RTB_Main.Select(offset + begin, word.Length);
                        RTB_Main.SelectionColor = dictionary[word];

                        int delta = begin + word.Length;
                        offset += delta;
                        tempText = tempText.Substring(delta, tempText.Length - delta);
                    }
                    else
                        break;
                }
            }

            Dictionary<string, Color> regex = controller.GetRegex();

            for (int i = 0; i < regex.Count; i++)
            {
                string pattern = regex.ElementAt(i).Key;
                string tempText = text.ToLower();
                int offset = 0;

                while (true)
                {
                    if (Regex.IsMatch(tempText, pattern))
                    {
                        Match match = Regex.Matches(tempText, pattern)[0];
                        int begin = match.Index;
                        //int end = begin + match.Length;

                        RTB_Main.Select(offset + begin, match.Length);
                        RTB_Main.SelectionColor = regex[pattern];

                        int delta = begin + match.Length;
                        offset += delta;
                        tempText = tempText.Substring(delta, tempText.Length - delta);
                    }
                    else
                        break;
                }
            }

            RTB_Main.Select(caretePosition, 0);

            //возобновляем обновление
            SendMessage(RTB_Main.Handle, WM_SETREDRAW, true, 0);
            RTB_Main.Refresh();

            initialization = false;
        }

        private void RTB_Main_TextChanged(object sender, EventArgs e)
        {
            if (!initialization)
            {
                fileChanged = true;

                RTB_Main.Undo();
                controller.AddUndoState(RTB_Main.Text);
                RTB_Main.Redo();

                timer.Stop();
                timer.Start();
            }
        }

        private void RTB_Main_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    {
                        initialization = true;

                        string text = RTB_Main.Text;
                        int begin = RTB_Main.SelectionStart;
                        int delta = 0;

                        if (e.Modifiers == Keys.Shift)
                        {
                            if (text[begin - 1] == '\t')
                            {
                                text = text.Remove(begin - 1, 1);
                                delta = -1;
                            }
                        }
                        else
                        {
                            text = text.Insert(begin, "\t");
                            delta = 1;
                        }
                        
                        RTB_Main.Text = text;
                        RTB_Main.SelectionStart = begin + delta;

                        initialization = false;

                        timer.Start();

                        break;
                    }
                case Keys.Z:
                    {
                        if (!(e.Modifiers == Keys.Control))
                            return;

                        Undo();

                        break;
                    }
            }
        }

        private void MI_Dictionary_Click(object sender, EventArgs e)
        {
            FDictionary form = new FDictionary(controller.GetDictionary());
            form.ShowDialog();
            if (form.Tag == null)
            {
                form.Dispose();
                return;
            }
            Dictionary<string, Color> newDictionary = (Dictionary<string, Color>)form.Tag;
            form.Dispose();
            controller.SetDistionary(newDictionary);
            timer.Start();
        }

        private void MI_Backcolor_Click(object sender, EventArgs e)
        {
            Color color = RTB_Main.BackColor;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color;
            colorDialog.ShowDialog();
            color = colorDialog.Color;
            RTB_Main.BackColor = color;
        }

        private void MI_Textcolor_Click(object sender, EventArgs e)
        {
            Color color = controller.GetTextColor();
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color;
            colorDialog.ShowDialog();
            color = colorDialog.Color;
            controller.SetTextColor(color);
            timer.Start();
        }

        private void MI_Font_Click(object sender, EventArgs e)
        {
            Font font = RTB_Main.Font;
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = font;
            fontDialog.ShowDialog();
            font = fontDialog.Font;
            RTB_Main.Font = font;
        }

        private void MI_Regex_Click(object sender, EventArgs e)
        {
            FDictionary form = new FDictionary(controller.GetRegex(), "Regex");
            form.ShowDialog();
            if (form.Tag == null)
            {
                form.Dispose();
                return;
            }
            Dictionary<string, Color> newRegex = (Dictionary<string, Color>)form.Tag;
            form.Dispose();
            controller.SetRegex(newRegex);
            timer.Start();
        }

        private void MI_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Text Files|*.txt",
                RestoreDirectory = true
            };
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                string path = ofd.FileName;
                
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string text = sr.ReadToEnd();
                        //initialization = true;
                        RTB_Main.Text = text;
                        //initialization = false;
                    }

                    controller.SetFileName(path);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ofd.Dispose();
                    fileChanged = false;
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void MI_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void MI_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void MI_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MI_Edit_DropDownOpening(object sender, EventArgs e)
        {
            MI_Undo.Text = string.Format("Undo [{0}]", controller.GetUndoAmount());
            MI_Redo.Text = string.Format("Redo [{0}]", controller.GetRedoAmount());
        }

        private void MI_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void MI_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void MI_Find_Click(object sender, EventArgs e)
        {
            string text = RTB_Main.SelectedText;
            FSearch form = new FSearch(RTB_Main, text)
            {
                Owner = this
            };
            form.Location = new Point(this.Location.X + this.Width / 2 - form.Width / 2, this.Location.Y + this.Height / 2 - form.Height / 2);
            form.Show();
        }

        private void SaveFile()
        {
            string path = controller.GetFileName();

            if (path == null || path == "")
            {
                SaveFileAs();
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    string text = RTB_Main.Text;
                    sw.WriteLine(text);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            fileChanged = false;
        }

        private void SaveFileAs()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text Files|*.txt",
                RestoreDirectory = true
            };
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                string path = sfd.FileName;

                try
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        string text = RTB_Main.Text;
                        sw.WriteLine(text);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sfd.Dispose();
                    Cursor.Current = Cursors.Default;
                }
            }

            fileChanged = false;
        }

        private void Undo()
        {
            string backup = controller.Undo();
            if (backup == null)
                return;
            
            //controller.AddRedoState(RTB_Main.Text);

            int selectionStart = RTB_Main.SelectionStart;

            initialization = true;
            RTB_Main.Text = backup;
            initialization = false;

            RTB_Main.SelectionStart = selectionStart;

            timer.Start();
        }

        private void MI_OpenDictionary_Click(object sender, EventArgs e)
        {

        }

        private void MI_OpenRegex_Click(object sender, EventArgs e)
        {

        }

        private void Redo()
        {
            string backup = controller.Redo();
            if (backup == null)
            {
                MessageBox.Show("!");
                return;
            }

            //initialization = true;
            RTB_Main.Text = backup;
            //initialization = false;

            timer.Start();
        }
    }
}