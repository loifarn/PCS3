namespace Week5
{
    partial class MPA_Form
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
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.LB_Display = new System.Windows.Forms.ListBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Field_PCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Field_Age = new System.Windows.Forms.TextBox();
            this.Field_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_CurrentFile = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(11, 142);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(75, 23);
            this.Btn_Create.TabIndex = 0;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(378, 165);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // LB_Display
            // 
            this.LB_Display.FormattingEnabled = true;
            this.LB_Display.Location = new System.Drawing.Point(216, 64);
            this.LB_Display.Name = "LB_Display";
            this.LB_Display.Size = new System.Drawing.Size(237, 95);
            this.LB_Display.TabIndex = 2;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(216, 165);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(85, 23);
            this.Btn_Edit.TabIndex = 3;
            this.Btn_Edit.Text = "Edit selected";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name: ";
            // 
            // Field_PCN
            // 
            this.Field_PCN.Location = new System.Drawing.Point(57, 90);
            this.Field_PCN.Name = "Field_PCN";
            this.Field_PCN.Size = new System.Drawing.Size(100, 20);
            this.Field_PCN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PCN: ";
            // 
            // Field_Age
            // 
            this.Field_Age.Location = new System.Drawing.Point(57, 116);
            this.Field_Age.Name = "Field_Age";
            this.Field_Age.Size = new System.Drawing.Size(100, 20);
            this.Field_Age.TabIndex = 9;
            // 
            // Field_Name
            // 
            this.Field_Name.Location = new System.Drawing.Point(57, 64);
            this.Field_Name.Name = "Field_Name";
            this.Field_Name.Size = new System.Drawing.Size(100, 20);
            this.Field_Name.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Create new people";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Open,
            this.Menu_Save});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(152, 22);
            this.Menu_Open.Text = "Open";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(152, 22);
            this.Menu_Save.Text = "Save";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // LBL_CurrentFile
            // 
            this.LBL_CurrentFile.AutoSize = true;
            this.LBL_CurrentFile.Location = new System.Drawing.Point(11, 210);
            this.LBL_CurrentFile.Name = "LBL_CurrentFile";
            this.LBL_CurrentFile.Size = new System.Drawing.Size(60, 13);
            this.LBL_CurrentFile.TabIndex = 13;
            this.LBL_CurrentFile.Text = "Current file:";
            // 
            // MPA_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 235);
            this.Controls.Add(this.LBL_CurrentFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Field_Name);
            this.Controls.Add(this.Field_Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Field_PCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.LB_Display);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MPA_Form";
            this.Text = "MPA_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.ListBox LB_Display;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Field_PCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Field_Age;
        private System.Windows.Forms.TextBox Field_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.Label LBL_CurrentFile;
    }
}