namespace Week3
{
    partial class FamilyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_morning = new System.Windows.Forms.Button();
            this.Btn_night = new System.Windows.Forms.Button();
            this.morningLabel = new System.Windows.Forms.Label();
            this.nightLabel = new System.Windows.Forms.Label();
            this.Dial_days = new System.Windows.Forms.NumericUpDown();
            this.Dial_hours = new System.Windows.Forms.NumericUpDown();
            this.familyListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dial_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dial_hours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Family";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day of the Week (1,2.....7)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours (1,2,.....,23,24)";
            // 
            // Btn_morning
            // 
            this.Btn_morning.Location = new System.Drawing.Point(316, 21);
            this.Btn_morning.Name = "Btn_morning";
            this.Btn_morning.Size = new System.Drawing.Size(94, 23);
            this.Btn_morning.TabIndex = 3;
            this.Btn_morning.Text = "Good morning";
            this.Btn_morning.UseVisualStyleBackColor = true;
            this.Btn_morning.Click += new System.EventHandler(this.Btn_morning_Click);
            // 
            // Btn_night
            // 
            this.Btn_night.Location = new System.Drawing.Point(316, 50);
            this.Btn_night.Name = "Btn_night";
            this.Btn_night.Size = new System.Drawing.Size(94, 23);
            this.Btn_night.TabIndex = 4;
            this.Btn_night.Text = "Good night";
            this.Btn_night.UseVisualStyleBackColor = true;
            this.Btn_night.Click += new System.EventHandler(this.Btn_night_Click);
            // 
            // morningLabel
            // 
            this.morningLabel.AutoSize = true;
            this.morningLabel.Location = new System.Drawing.Point(416, 24);
            this.morningLabel.Name = "morningLabel";
            this.morningLabel.Size = new System.Drawing.Size(63, 13);
            this.morningLabel.TabIndex = 5;
            this.morningLabel.Text = "Placeholder";
            // 
            // nightLabel
            // 
            this.nightLabel.AutoSize = true;
            this.nightLabel.Location = new System.Drawing.Point(416, 55);
            this.nightLabel.Name = "nightLabel";
            this.nightLabel.Size = new System.Drawing.Size(63, 13);
            this.nightLabel.TabIndex = 6;
            this.nightLabel.Text = "Placeholder";
            // 
            // Dial_days
            // 
            this.Dial_days.Location = new System.Drawing.Point(277, 24);
            this.Dial_days.Name = "Dial_days";
            this.Dial_days.Size = new System.Drawing.Size(33, 20);
            this.Dial_days.TabIndex = 7;
            // 
            // Dial_hours
            // 
            this.Dial_hours.Location = new System.Drawing.Point(277, 50);
            this.Dial_hours.Name = "Dial_hours";
            this.Dial_hours.Size = new System.Drawing.Size(33, 20);
            this.Dial_hours.TabIndex = 8;
            // 
            // familyListBox
            // 
            this.familyListBox.FormattingEnabled = true;
            this.familyListBox.Location = new System.Drawing.Point(15, 34);
            this.familyListBox.Name = "familyListBox";
            this.familyListBox.Size = new System.Drawing.Size(120, 95);
            this.familyListBox.TabIndex = 9;
            // 
            // FamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 141);
            this.Controls.Add(this.familyListBox);
            this.Controls.Add(this.Dial_hours);
            this.Controls.Add(this.Dial_days);
            this.Controls.Add(this.nightLabel);
            this.Controls.Add(this.morningLabel);
            this.Controls.Add(this.Btn_night);
            this.Controls.Add(this.Btn_morning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FamilyForm";
            this.Text = "FamilyForm";
            ((System.ComponentModel.ISupportInitialize)(this.Dial_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dial_hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_morning;
        private System.Windows.Forms.Button Btn_night;
        private System.Windows.Forms.Label morningLabel;
        private System.Windows.Forms.Label nightLabel;
        private System.Windows.Forms.NumericUpDown Dial_days;
        private System.Windows.Forms.NumericUpDown Dial_hours;
        private System.Windows.Forms.ListBox familyListBox;
    }
}

