namespace TextEditor
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.RTB_Main = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Backcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Textcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_Dictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Regex = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_OpenDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_OpenRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB_Main
            // 
            this.RTB_Main.DetectUrls = false;
            this.RTB_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Main.Location = new System.Drawing.Point(0, 24);
            this.RTB_Main.Name = "RTB_Main";
            this.RTB_Main.Size = new System.Drawing.Size(784, 537);
            this.RTB_Main.TabIndex = 0;
            this.RTB_Main.Text = "";
            this.RTB_Main.WordWrap = false;
            this.RTB_Main.TextChanged += new System.EventHandler(this.RTB_Main_TextChanged);
            this.RTB_Main.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.RTB_Main_PreviewKeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.MI_Edit,
            this.searchToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_OpenFile,
            this.MI_SaveFile,
            this.MI_SaveAs,
            this.toolStripMenuItem3,
            this.MI_OpenDictionary,
            this.MI_OpenRegex,
            this.toolStripMenuItem2,
            this.MI_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MI_OpenFile
            // 
            this.MI_OpenFile.Name = "MI_OpenFile";
            this.MI_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MI_OpenFile.Size = new System.Drawing.Size(195, 22);
            this.MI_OpenFile.Text = "Open";
            this.MI_OpenFile.Click += new System.EventHandler(this.MI_OpenFile_Click);
            // 
            // MI_SaveFile
            // 
            this.MI_SaveFile.Name = "MI_SaveFile";
            this.MI_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MI_SaveFile.Size = new System.Drawing.Size(195, 22);
            this.MI_SaveFile.Text = "Save";
            this.MI_SaveFile.Click += new System.EventHandler(this.MI_SaveFile_Click);
            // 
            // MI_SaveAs
            // 
            this.MI_SaveAs.Name = "MI_SaveAs";
            this.MI_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MI_SaveAs.Size = new System.Drawing.Size(195, 22);
            this.MI_SaveAs.Text = "Save As...";
            this.MI_SaveAs.Click += new System.EventHandler(this.MI_SaveAs_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            this.toolStripMenuItem2.Visible = false;
            // 
            // MI_Exit
            // 
            this.MI_Exit.Name = "MI_Exit";
            this.MI_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MI_Exit.Size = new System.Drawing.Size(195, 22);
            this.MI_Exit.Text = "Exit";
            this.MI_Exit.Click += new System.EventHandler(this.MI_Exit_Click);
            // 
            // MI_Edit
            // 
            this.MI_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Undo,
            this.MI_Redo});
            this.MI_Edit.Name = "MI_Edit";
            this.MI_Edit.Size = new System.Drawing.Size(39, 20);
            this.MI_Edit.Text = "Edit";
            this.MI_Edit.DropDownOpening += new System.EventHandler(this.MI_Edit_DropDownOpening);
            // 
            // MI_Undo
            // 
            this.MI_Undo.Image = global::TextEditor.Properties.Resources.Undo;
            this.MI_Undo.Name = "MI_Undo";
            this.MI_Undo.Size = new System.Drawing.Size(180, 22);
            this.MI_Undo.Text = "Undo";
            this.MI_Undo.Click += new System.EventHandler(this.MI_Undo_Click);
            // 
            // MI_Redo
            // 
            this.MI_Redo.Name = "MI_Redo";
            this.MI_Redo.Size = new System.Drawing.Size(180, 22);
            this.MI_Redo.Text = "Redo";
            this.MI_Redo.Visible = false;
            this.MI_Redo.Click += new System.EventHandler(this.MI_Redo_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Find});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // MI_Find
            // 
            this.MI_Find.Name = "MI_Find";
            this.MI_Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MI_Find.Size = new System.Drawing.Size(180, 22);
            this.MI_Find.Text = "Find...";
            this.MI_Find.Click += new System.EventHandler(this.MI_Find_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Font,
            this.MI_Backcolor,
            this.MI_Textcolor,
            this.toolStripMenuItem1,
            this.MI_Dictionary,
            this.MI_Regex});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // MI_Font
            // 
            this.MI_Font.Name = "MI_Font";
            this.MI_Font.Size = new System.Drawing.Size(180, 22);
            this.MI_Font.Text = "Font...";
            this.MI_Font.Click += new System.EventHandler(this.MI_Font_Click);
            // 
            // MI_Backcolor
            // 
            this.MI_Backcolor.Name = "MI_Backcolor";
            this.MI_Backcolor.Size = new System.Drawing.Size(180, 22);
            this.MI_Backcolor.Text = "Backcolor...";
            this.MI_Backcolor.Click += new System.EventHandler(this.MI_Backcolor_Click);
            // 
            // MI_Textcolor
            // 
            this.MI_Textcolor.Name = "MI_Textcolor";
            this.MI_Textcolor.Size = new System.Drawing.Size(180, 22);
            this.MI_Textcolor.Text = "Textcolor...";
            this.MI_Textcolor.Click += new System.EventHandler(this.MI_Textcolor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MI_Dictionary
            // 
            this.MI_Dictionary.Name = "MI_Dictionary";
            this.MI_Dictionary.Size = new System.Drawing.Size(180, 22);
            this.MI_Dictionary.Text = "Dictionary...";
            this.MI_Dictionary.Click += new System.EventHandler(this.MI_Dictionary_Click);
            // 
            // MI_Regex
            // 
            this.MI_Regex.Name = "MI_Regex";
            this.MI_Regex.Size = new System.Drawing.Size(180, 22);
            this.MI_Regex.Text = "Regex...";
            this.MI_Regex.Click += new System.EventHandler(this.MI_Regex_Click);
            // 
            // MI_OpenDictionary
            // 
            this.MI_OpenDictionary.Name = "MI_OpenDictionary";
            this.MI_OpenDictionary.Size = new System.Drawing.Size(195, 22);
            this.MI_OpenDictionary.Text = "Open Dictionary...";
            this.MI_OpenDictionary.Visible = false;
            this.MI_OpenDictionary.Click += new System.EventHandler(this.MI_OpenDictionary_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(192, 6);
            // 
            // MI_OpenRegex
            // 
            this.MI_OpenRegex.Name = "MI_OpenRegex";
            this.MI_OpenRegex.Size = new System.Drawing.Size(195, 22);
            this.MI_OpenRegex.Text = "Open Regex...";
            this.MI_OpenRegex.Visible = false;
            this.MI_OpenRegex.Click += new System.EventHandler(this.MI_OpenRegex_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RTB_Main);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Dictionary;
        private System.Windows.Forms.ToolStripMenuItem MI_Backcolor;
        private System.Windows.Forms.ToolStripMenuItem MI_Textcolor;
        private System.Windows.Forms.ToolStripMenuItem MI_Font;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MI_Regex;
        private System.Windows.Forms.ToolStripMenuItem MI_Find;
        private System.Windows.Forms.ToolStripMenuItem MI_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem MI_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem MI_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MI_Exit;
        private System.Windows.Forms.ToolStripMenuItem MI_Edit;
        private System.Windows.Forms.ToolStripMenuItem MI_Undo;
        private System.Windows.Forms.ToolStripMenuItem MI_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MI_OpenDictionary;
        private System.Windows.Forms.ToolStripMenuItem MI_OpenRegex;
    }
}

