namespace TextEditor
{
    partial class FDictionary
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
            this.LB_Main = new System.Windows.Forms.ListBox();
            this.PB_Color = new System.Windows.Forms.PictureBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Main
            // 
            this.LB_Main.FormattingEnabled = true;
            this.LB_Main.Location = new System.Drawing.Point(12, 12);
            this.LB_Main.Name = "LB_Main";
            this.LB_Main.Size = new System.Drawing.Size(280, 225);
            this.LB_Main.TabIndex = 0;
            this.LB_Main.SelectedIndexChanged += new System.EventHandler(this.LB_Main_SelectedIndexChanged);
            this.LB_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Main_MouseUp);
            // 
            // PB_Color
            // 
            this.PB_Color.Location = new System.Drawing.Point(12, 247);
            this.PB_Color.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Color.Name = "PB_Color";
            this.PB_Color.Size = new System.Drawing.Size(21, 21);
            this.PB_Color.TabIndex = 1;
            this.PB_Color.TabStop = false;
            this.PB_Color.Click += new System.EventHandler(this.PB_Color_Click);
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(36, 246);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(23, 23);
            this.B_Add.TabIndex = 2;
            this.B_Add.Text = "+";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(65, 246);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(23, 23);
            this.B_Delete.TabIndex = 3;
            this.B_Delete.Text = "–";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(136, 246);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(75, 23);
            this.B_Close.TabIndex = 4;
            this.B_Close.Text = "OK";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(217, 246);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 5;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // FDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.PB_Color);
            this.Controls.Add(this.LB_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDictionary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.FDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Main;
        private System.Windows.Forms.PictureBox PB_Color;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Cancel;
    }
}