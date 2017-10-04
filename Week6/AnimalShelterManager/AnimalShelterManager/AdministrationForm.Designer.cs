namespace AnimalShelterManager
{
    partial class AdministrationForm
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
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpLastWalkInThePark = new System.Windows.Forms.DateTimePicker();
            this.dtpDateBroughtIn = new System.Windows.Forms.DateTimePicker();
            this.tbExtraCatInfo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbChipNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.btnShowInfoDogs = new System.Windows.Forms.Button();
            this.btnRemoveAnimal = new System.Windows.Forms.Button();
            this.btnShowInfoAllAnimals = new System.Windows.Forms.Button();
            this.btnCreateAnimal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelListBoxTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRemoveChipNr = new System.Windows.Forms.TextBox();
            this.btnTakeDogForAWalk = new System.Windows.Forms.Button();
            this.tbWalkChipNr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbWalkEmployee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNrWalksChipNr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNrWalks = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.Location = new System.Drawing.Point(28, 142);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(82, 17);
            this.rbCat.TabIndex = 39;
            this.rbCat.TabStop = true;
            this.rbCat.Text = "create a cat";
            this.rbCat.UseVisualStyleBackColor = true;
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Checked = true;
            this.rbDog.Location = new System.Drawing.Point(29, 215);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(85, 17);
            this.rbDog.TabIndex = 38;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "create a dog";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "last walk outside";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "date brought in";
            // 
            // dtpLastWalkInThePark
            // 
            this.dtpLastWalkInThePark.Location = new System.Drawing.Point(98, 19);
            this.dtpLastWalkInThePark.Name = "dtpLastWalkInThePark";
            this.dtpLastWalkInThePark.Size = new System.Drawing.Size(187, 20);
            this.dtpLastWalkInThePark.TabIndex = 35;
            // 
            // dtpDateBroughtIn
            // 
            this.dtpDateBroughtIn.Location = new System.Drawing.Point(88, 72);
            this.dtpDateBroughtIn.Name = "dtpDateBroughtIn";
            this.dtpDateBroughtIn.Size = new System.Drawing.Size(181, 20);
            this.dtpDateBroughtIn.TabIndex = 34;
            // 
            // tbExtraCatInfo
            // 
            this.tbExtraCatInfo.Location = new System.Drawing.Point(70, 13);
            this.tbExtraCatInfo.Name = "tbExtraCatInfo";
            this.tbExtraCatInfo.Size = new System.Drawing.Size(189, 20);
            this.tbExtraCatInfo.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(111, 20);
            this.tbName.TabIndex = 32;
            // 
            // tbChipNr
            // 
            this.tbChipNr.Location = new System.Drawing.Point(88, 22);
            this.tbChipNr.Name = "tbChipNr";
            this.tbChipNr.Size = new System.Drawing.Size(111, 20);
            this.tbChipNr.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "chipnr";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(311, 65);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(470, 303);
            this.listBoxAnimals.TabIndex = 27;
            // 
            // btnShowInfoDogs
            // 
            this.btnShowInfoDogs.Location = new System.Drawing.Point(654, 33);
            this.btnShowInfoDogs.Name = "btnShowInfoDogs";
            this.btnShowInfoDogs.Size = new System.Drawing.Size(127, 29);
            this.btnShowInfoDogs.TabIndex = 26;
            this.btnShowInfoDogs.Text = "Show info dogs";
            this.btnShowInfoDogs.UseVisualStyleBackColor = true;
            this.btnShowInfoDogs.Click += new System.EventHandler(this.btnShowInfoDogs_Click);
            // 
            // btnRemoveAnimal
            // 
            this.btnRemoveAnimal.Location = new System.Drawing.Point(91, 387);
            this.btnRemoveAnimal.Name = "btnRemoveAnimal";
            this.btnRemoveAnimal.Size = new System.Drawing.Size(112, 27);
            this.btnRemoveAnimal.TabIndex = 25;
            this.btnRemoveAnimal.Text = "Remove animal";
            this.btnRemoveAnimal.UseVisualStyleBackColor = true;
            this.btnRemoveAnimal.Click += new System.EventHandler(this.btnRemoveAnimal_Click);
            // 
            // btnShowInfoAllAnimals
            // 
            this.btnShowInfoAllAnimals.Location = new System.Drawing.Point(521, 37);
            this.btnShowInfoAllAnimals.Name = "btnShowInfoAllAnimals";
            this.btnShowInfoAllAnimals.Size = new System.Drawing.Size(127, 23);
            this.btnShowInfoAllAnimals.TabIndex = 24;
            this.btnShowInfoAllAnimals.Text = "Show info all animals";
            this.btnShowInfoAllAnimals.UseVisualStyleBackColor = true;
            this.btnShowInfoAllAnimals.Click += new System.EventHandler(this.btnShowInfoAllAnimals_Click);
            // 
            // btnCreateAnimal
            // 
            this.btnCreateAnimal.Location = new System.Drawing.Point(82, 280);
            this.btnCreateAnimal.Name = "btnCreateAnimal";
            this.btnCreateAnimal.Size = new System.Drawing.Size(114, 23);
            this.btnCreateAnimal.TabIndex = 23;
            this.btnCreateAnimal.Text = "Create animal";
            this.btnCreateAnimal.UseVisualStyleBackColor = true;
            this.btnCreateAnimal.Click += new System.EventHandler(this.btnCreateAnimal_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbChipNr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpDateBroughtIn);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 104);
            this.panel1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "animal data";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbExtraCatInfo);
            this.panel2.Location = new System.Drawing.Point(11, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 45);
            this.panel2.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "bad habbit";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtpLastWalkInThePark);
            this.panel3.Location = new System.Drawing.Point(12, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 49);
            this.panel3.TabIndex = 45;
            // 
            // labelListBoxTitle
            // 
            this.labelListBoxTitle.AutoSize = true;
            this.labelListBoxTitle.Location = new System.Drawing.Point(308, 42);
            this.labelListBoxTitle.Name = "labelListBoxTitle";
            this.labelListBoxTitle.Size = new System.Drawing.Size(83, 13);
            this.labelListBoxTitle.TabIndex = 46;
            this.labelListBoxTitle.Text = "labelListBoxTitle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "with chip number";
            // 
            // tbRemoveChipNr
            // 
            this.tbRemoveChipNr.Location = new System.Drawing.Point(96, 14);
            this.tbRemoveChipNr.Name = "tbRemoveChipNr";
            this.tbRemoveChipNr.Size = new System.Drawing.Size(100, 20);
            this.tbRemoveChipNr.TabIndex = 48;
            // 
            // btnTakeDogForAWalk
            // 
            this.btnTakeDogForAWalk.Location = new System.Drawing.Point(343, 484);
            this.btnTakeDogForAWalk.Name = "btnTakeDogForAWalk";
            this.btnTakeDogForAWalk.Size = new System.Drawing.Size(134, 29);
            this.btnTakeDogForAWalk.TabIndex = 49;
            this.btnTakeDogForAWalk.Text = "Take dog for a walk";
            this.btnTakeDogForAWalk.UseVisualStyleBackColor = true;
            // 
            // tbWalkChipNr
            // 
            this.tbWalkChipNr.Location = new System.Drawing.Point(110, 14);
            this.tbWalkChipNr.Name = "tbWalkChipNr";
            this.tbWalkChipNr.Size = new System.Drawing.Size(100, 20);
            this.tbWalkChipNr.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "with chip number";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tbRemoveChipNr);
            this.panel4.Location = new System.Drawing.Point(19, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 47);
            this.panel4.TabIndex = 52;
            // 
            // tbWalkEmployee
            // 
            this.tbWalkEmployee.Location = new System.Drawing.Point(110, 45);
            this.tbWalkEmployee.Name = "tbWalkEmployee";
            this.tbWalkEmployee.Size = new System.Drawing.Size(100, 20);
            this.tbWalkEmployee.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "employee name";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tbWalkChipNr);
            this.panel5.Controls.Add(this.tbWalkEmployee);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(311, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 83);
            this.panel5.TabIndex = 55;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbNrWalksChipNr);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(554, 385);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 83);
            this.panel6.TabIndex = 56;
            // 
            // tbNrWalksChipNr
            // 
            this.tbNrWalksChipNr.Location = new System.Drawing.Point(109, 17);
            this.tbNrWalksChipNr.Name = "tbNrWalksChipNr";
            this.tbNrWalksChipNr.Size = new System.Drawing.Size(88, 20);
            this.tbNrWalksChipNr.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "chip number";
            // 
            // btnNrWalks
            // 
            this.btnNrWalks.Location = new System.Drawing.Point(593, 484);
            this.btnNrWalks.Name = "btnNrWalks";
            this.btnNrWalks.Size = new System.Drawing.Size(132, 23);
            this.btnNrWalks.TabIndex = 57;
            this.btnNrWalks.Text = "Get history of walks";
            this.btnNrWalks.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "AdminFormMenu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuSave});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(152, 22);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(152, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 534);
            this.Controls.Add(this.btnNrWalks);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnTakeDogForAWalk);
            this.Controls.Add(this.rbCat);
            this.Controls.Add(this.rbDog);
            this.Controls.Add(this.labelListBoxTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.btnShowInfoDogs);
            this.Controls.Add(this.btnRemoveAnimal);
            this.Controls.Add(this.btnShowInfoAllAnimals);
            this.Controls.Add(this.btnCreateAnimal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrationForm";
            this.Text = "Administration Form - Animal Shelter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLastWalkInThePark;
        private System.Windows.Forms.DateTimePicker dtpDateBroughtIn;
        private System.Windows.Forms.TextBox tbExtraCatInfo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbChipNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Button btnShowInfoDogs;
        private System.Windows.Forms.Button btnRemoveAnimal;
        private System.Windows.Forms.Button btnShowInfoAllAnimals;
        private System.Windows.Forms.Button btnCreateAnimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelListBoxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRemoveChipNr;
        private System.Windows.Forms.Button btnTakeDogForAWalk;
        private System.Windows.Forms.TextBox tbWalkChipNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbWalkEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNrWalksChipNr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNrWalks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
    }
}

