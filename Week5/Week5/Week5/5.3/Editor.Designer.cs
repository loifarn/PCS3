namespace Week5
{
    partial class Editor
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
            this.Field_EditName = new System.Windows.Forms.TextBox();
            this.Field_EditPCN = new System.Windows.Forms.TextBox();
            this.Field_EditAge = new System.Windows.Forms.TextBox();
            this.LB_EditName = new System.Windows.Forms.Label();
            this.LB_EditPCN = new System.Windows.Forms.Label();
            this.LB_EditAge = new System.Windows.Forms.Label();
            this.Btn_EditSave = new System.Windows.Forms.Button();
            this.Btn_EditCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Field_EditName
            // 
            this.Field_EditName.Location = new System.Drawing.Point(53, 6);
            this.Field_EditName.Name = "Field_EditName";
            this.Field_EditName.Size = new System.Drawing.Size(156, 20);
            this.Field_EditName.TabIndex = 0;
            // 
            // Field_EditPCN
            // 
            this.Field_EditPCN.Location = new System.Drawing.Point(53, 32);
            this.Field_EditPCN.Name = "Field_EditPCN";
            this.Field_EditPCN.Size = new System.Drawing.Size(156, 20);
            this.Field_EditPCN.TabIndex = 1;
            // 
            // Field_EditAge
            // 
            this.Field_EditAge.Location = new System.Drawing.Point(53, 58);
            this.Field_EditAge.Name = "Field_EditAge";
            this.Field_EditAge.Size = new System.Drawing.Size(156, 20);
            this.Field_EditAge.TabIndex = 2;
            // 
            // LB_EditName
            // 
            this.LB_EditName.AutoSize = true;
            this.LB_EditName.Location = new System.Drawing.Point(12, 9);
            this.LB_EditName.Name = "LB_EditName";
            this.LB_EditName.Size = new System.Drawing.Size(35, 13);
            this.LB_EditName.TabIndex = 3;
            this.LB_EditName.Text = "Name";
            // 
            // LB_EditPCN
            // 
            this.LB_EditPCN.AutoSize = true;
            this.LB_EditPCN.Location = new System.Drawing.Point(18, 32);
            this.LB_EditPCN.Name = "LB_EditPCN";
            this.LB_EditPCN.Size = new System.Drawing.Size(29, 13);
            this.LB_EditPCN.TabIndex = 4;
            this.LB_EditPCN.Text = "PCN";
            // 
            // LB_EditAge
            // 
            this.LB_EditAge.AutoSize = true;
            this.LB_EditAge.Location = new System.Drawing.Point(21, 58);
            this.LB_EditAge.Name = "LB_EditAge";
            this.LB_EditAge.Size = new System.Drawing.Size(26, 13);
            this.LB_EditAge.TabIndex = 5;
            this.LB_EditAge.Text = "Age";
            // 
            // Btn_EditSave
            // 
            this.Btn_EditSave.Location = new System.Drawing.Point(53, 85);
            this.Btn_EditSave.Name = "Btn_EditSave";
            this.Btn_EditSave.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditSave.TabIndex = 6;
            this.Btn_EditSave.Text = "Save";
            this.Btn_EditSave.UseVisualStyleBackColor = true;
            this.Btn_EditSave.Click += new System.EventHandler(this.Btn_EditSave_Click);
            // 
            // Btn_EditCancel
            // 
            this.Btn_EditCancel.Location = new System.Drawing.Point(134, 84);
            this.Btn_EditCancel.Name = "Btn_EditCancel";
            this.Btn_EditCancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditCancel.TabIndex = 7;
            this.Btn_EditCancel.Text = "Cancel";
            this.Btn_EditCancel.UseVisualStyleBackColor = true;
            this.Btn_EditCancel.Click += new System.EventHandler(this.Btn_EditCancel_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 127);
            this.Controls.Add(this.Btn_EditCancel);
            this.Controls.Add(this.Btn_EditSave);
            this.Controls.Add(this.LB_EditAge);
            this.Controls.Add(this.LB_EditPCN);
            this.Controls.Add(this.LB_EditName);
            this.Controls.Add(this.Field_EditAge);
            this.Controls.Add(this.Field_EditPCN);
            this.Controls.Add(this.Field_EditName);
            this.Name = "Editor";
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Field_EditName;
        private System.Windows.Forms.TextBox Field_EditPCN;
        private System.Windows.Forms.TextBox Field_EditAge;
        private System.Windows.Forms.Label LB_EditName;
        private System.Windows.Forms.Label LB_EditPCN;
        private System.Windows.Forms.Label LB_EditAge;
        private System.Windows.Forms.Button Btn_EditSave;
        private System.Windows.Forms.Button Btn_EditCancel;
    }
}