namespace TextEditor
{
    partial class FSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SearchText = new System.Windows.Forms.TextBox();
            this.B_Find = new System.Windows.Forms.Button();
            this.CB_CaseSensitive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NewText = new System.Windows.Forms.TextBox();
            this.B_Replace = new System.Windows.Forms.Button();
            this.B_ReplaceAll = new System.Windows.Forms.Button();
            this.B_CountMatches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // TB_SearchText
            // 
            this.TB_SearchText.Location = new System.Drawing.Point(83, 12);
            this.TB_SearchText.Name = "TB_SearchText";
            this.TB_SearchText.Size = new System.Drawing.Size(143, 20);
            this.TB_SearchText.TabIndex = 1;
            // 
            // B_Find
            // 
            this.B_Find.Location = new System.Drawing.Point(232, 10);
            this.B_Find.Name = "B_Find";
            this.B_Find.Size = new System.Drawing.Size(100, 23);
            this.B_Find.TabIndex = 2;
            this.B_Find.Text = "Find Next";
            this.B_Find.UseVisualStyleBackColor = true;
            this.B_Find.Click += new System.EventHandler(this.B_Find_Click);
            // 
            // CB_CaseSensitive
            // 
            this.CB_CaseSensitive.AutoSize = true;
            this.CB_CaseSensitive.Location = new System.Drawing.Point(12, 101);
            this.CB_CaseSensitive.Name = "CB_CaseSensitive";
            this.CB_CaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.CB_CaseSensitive.TabIndex = 8;
            this.CB_CaseSensitive.TabStop = false;
            this.CB_CaseSensitive.Text = "Case Sensitive";
            this.CB_CaseSensitive.UseVisualStyleBackColor = true;
            this.CB_CaseSensitive.CheckedChanged += new System.EventHandler(this.CB_CaseSensitive_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace on:";
            // 
            // TB_NewText
            // 
            this.TB_NewText.Location = new System.Drawing.Point(83, 41);
            this.TB_NewText.Name = "TB_NewText";
            this.TB_NewText.Size = new System.Drawing.Size(143, 20);
            this.TB_NewText.TabIndex = 4;
            // 
            // B_Replace
            // 
            this.B_Replace.Location = new System.Drawing.Point(232, 39);
            this.B_Replace.Name = "B_Replace";
            this.B_Replace.Size = new System.Drawing.Size(100, 23);
            this.B_Replace.TabIndex = 5;
            this.B_Replace.Text = "Replace";
            this.B_Replace.UseVisualStyleBackColor = true;
            this.B_Replace.Click += new System.EventHandler(this.B_Replace_Click);
            // 
            // B_ReplaceAll
            // 
            this.B_ReplaceAll.Location = new System.Drawing.Point(232, 68);
            this.B_ReplaceAll.Name = "B_ReplaceAll";
            this.B_ReplaceAll.Size = new System.Drawing.Size(100, 23);
            this.B_ReplaceAll.TabIndex = 6;
            this.B_ReplaceAll.Text = "Replace All";
            this.B_ReplaceAll.UseVisualStyleBackColor = true;
            this.B_ReplaceAll.Click += new System.EventHandler(this.B_ReplaceAll_Click);
            // 
            // B_CountMatches
            // 
            this.B_CountMatches.Location = new System.Drawing.Point(232, 97);
            this.B_CountMatches.Name = "B_CountMatches";
            this.B_CountMatches.Size = new System.Drawing.Size(100, 23);
            this.B_CountMatches.TabIndex = 7;
            this.B_CountMatches.Text = "Count Matches";
            this.B_CountMatches.UseVisualStyleBackColor = true;
            this.B_CountMatches.Click += new System.EventHandler(this.B_CountMatches_Click);
            // 
            // FSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 133);
            this.Controls.Add(this.B_CountMatches);
            this.Controls.Add(this.B_ReplaceAll);
            this.Controls.Add(this.B_Replace);
            this.Controls.Add(this.TB_NewText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_CaseSensitive);
            this.Controls.Add(this.B_Find);
            this.Controls.Add(this.TB_SearchText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.FSearch_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FSearch_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SearchText;
        private System.Windows.Forms.Button B_Find;
        private System.Windows.Forms.CheckBox CB_CaseSensitive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NewText;
        private System.Windows.Forms.Button B_Replace;
        private System.Windows.Forms.Button B_ReplaceAll;
        private System.Windows.Forms.Button B_CountMatches;
    }
}