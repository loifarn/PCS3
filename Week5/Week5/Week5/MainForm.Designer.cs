namespace Week5
{
    partial class MainForm
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
            this.Lbl_File = new System.Windows.Forms.Label();
            this.Lbl_Text = new System.Windows.Forms.Label();
            this.RTB_Display = new System.Windows.Forms.RichTextBox();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_File
            // 
            this.Lbl_File.AutoSize = true;
            this.Lbl_File.Location = new System.Drawing.Point(14, 9);
            this.Lbl_File.Name = "Lbl_File";
            this.Lbl_File.Size = new System.Drawing.Size(29, 13);
            this.Lbl_File.TabIndex = 0;
            this.Lbl_File.Text = "File: ";
            // 
            // Lbl_Text
            // 
            this.Lbl_Text.AutoSize = true;
            this.Lbl_Text.Location = new System.Drawing.Point(12, 26);
            this.Lbl_Text.Name = "Lbl_Text";
            this.Lbl_Text.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Text.TabIndex = 1;
            this.Lbl_Text.Text = "Text:";
            // 
            // RTB_Display
            // 
            this.RTB_Display.Location = new System.Drawing.Point(49, 26);
            this.RTB_Display.Name = "RTB_Display";
            this.RTB_Display.Size = new System.Drawing.Size(218, 199);
            this.RTB_Display.TabIndex = 2;
            this.RTB_Display.Text = "";
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(49, 226);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 23);
            this.Btn_Load.TabIndex = 3;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(130, 226);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.RTB_Display);
            this.Controls.Add(this.Lbl_Text);
            this.Controls.Add(this.Lbl_File);
            this.Name = "MainForm";
            this.Text = "Simple Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_File;
        private System.Windows.Forms.Label Lbl_Text;
        private System.Windows.Forms.RichTextBox RTB_Display;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Save;
    }
}

