﻿namespace School
{
    partial class Form1
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
            this.buttonSchoolYearStudent = new System.Windows.Forms.Button();
            this.buttonBirthdayStudent = new System.Windows.Forms.Button();
            this.buttonAddModule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPromote = new System.Windows.Forms.Button();
            this.buttonBirthdayTeacher = new System.Windows.Forms.Button();
            this.buttonSchoolYearTeacher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStudent = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.teacherAddress = new System.Windows.Forms.Button();
            this.studentAddress = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSchoolYearStudent
            // 
            this.buttonSchoolYearStudent.Location = new System.Drawing.Point(172, 176);
            this.buttonSchoolYearStudent.Name = "buttonSchoolYearStudent";
            this.buttonSchoolYearStudent.Size = new System.Drawing.Size(110, 23);
            this.buttonSchoolYearStudent.TabIndex = 5;
            this.buttonSchoolYearStudent.Text = "another school year";
            this.buttonSchoolYearStudent.UseVisualStyleBackColor = true;
            this.buttonSchoolYearStudent.Click += new System.EventHandler(this.buttonSchoolYearStudent_Click);
            // 
            // buttonBirthdayStudent
            // 
            this.buttonBirthdayStudent.Location = new System.Drawing.Point(172, 209);
            this.buttonBirthdayStudent.Name = "buttonBirthdayStudent";
            this.buttonBirthdayStudent.Size = new System.Drawing.Size(110, 23);
            this.buttonBirthdayStudent.TabIndex = 7;
            this.buttonBirthdayStudent.Text = "celebrate birthday!";
            this.buttonBirthdayStudent.UseVisualStyleBackColor = true;
            this.buttonBirthdayStudent.Click += new System.EventHandler(this.buttonBirthdayStudent_Click);
            // 
            // buttonAddModule
            // 
            this.buttonAddModule.Location = new System.Drawing.Point(172, 242);
            this.buttonAddModule.Name = "buttonAddModule";
            this.buttonAddModule.Size = new System.Drawing.Size(110, 23);
            this.buttonAddModule.TabIndex = 9;
            this.buttonAddModule.Text = "add module ec\'s";
            this.buttonAddModule.UseVisualStyleBackColor = true;
            this.buttonAddModule.Click += new System.EventHandler(this.buttonAddModule_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTeacher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 94);
            this.panel1.TabIndex = 10;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(10, 28);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(36, 13);
            this.labelTeacher.TabIndex = 1;
            this.labelTeacher.Text = "name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "teacher start";
            // 
            // buttonPromote
            // 
            this.buttonPromote.Location = new System.Drawing.Point(172, 83);
            this.buttonPromote.Name = "buttonPromote";
            this.buttonPromote.Size = new System.Drawing.Size(110, 23);
            this.buttonPromote.TabIndex = 14;
            this.buttonPromote.Text = "make promotion";
            this.buttonPromote.UseVisualStyleBackColor = true;
            this.buttonPromote.Click += new System.EventHandler(this.buttonPromote_Click);
            // 
            // buttonBirthdayTeacher
            // 
            this.buttonBirthdayTeacher.Location = new System.Drawing.Point(172, 49);
            this.buttonBirthdayTeacher.Name = "buttonBirthdayTeacher";
            this.buttonBirthdayTeacher.Size = new System.Drawing.Size(110, 23);
            this.buttonBirthdayTeacher.TabIndex = 13;
            this.buttonBirthdayTeacher.Text = "celebrate birthday!";
            this.buttonBirthdayTeacher.UseVisualStyleBackColor = true;
            this.buttonBirthdayTeacher.Click += new System.EventHandler(this.buttonBirthdayTeacher_Click);
            // 
            // buttonSchoolYearTeacher
            // 
            this.buttonSchoolYearTeacher.Location = new System.Drawing.Point(172, 15);
            this.buttonSchoolYearTeacher.Name = "buttonSchoolYearTeacher";
            this.buttonSchoolYearTeacher.Size = new System.Drawing.Size(110, 23);
            this.buttonSchoolYearTeacher.TabIndex = 12;
            this.buttonSchoolYearTeacher.Text = "another school year";
            this.buttonSchoolYearTeacher.UseVisualStyleBackColor = true;
            this.buttonSchoolYearTeacher.Click += new System.EventHandler(this.buttonSchoolYearTeacher_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelStudent);
            this.panel2.Controls.Add(this.studentLabel);
            this.panel2.Location = new System.Drawing.Point(12, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 94);
            this.panel2.TabIndex = 13;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(10, 28);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(36, 13);
            this.labelStudent.TabIndex = 1;
            this.labelStudent.Text = "name:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(10, 4);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(65, 13);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "student start";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(298, 12);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(234, 562);
            this.richTextBoxLog.TabIndex = 16;
            this.richTextBoxLog.Text = "";
            // 
            // teacherAddress
            // 
            this.teacherAddress.Location = new System.Drawing.Point(172, 112);
            this.teacherAddress.Name = "teacherAddress";
            this.teacherAddress.Size = new System.Drawing.Size(110, 23);
            this.teacherAddress.TabIndex = 17;
            this.teacherAddress.Text = "show address";
            this.teacherAddress.UseVisualStyleBackColor = true;
            this.teacherAddress.Click += new System.EventHandler(this.teacherAddress_Click);
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(172, 271);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(110, 23);
            this.studentAddress.TabIndex = 18;
            this.studentAddress.Text = "show address";
            this.studentAddress.UseVisualStyleBackColor = true;
            this.studentAddress.Click += new System.EventHandler(this.studentAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 586);
            this.Controls.Add(this.studentAddress);
            this.Controls.Add(this.teacherAddress);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonPromote);
            this.Controls.Add(this.buttonBirthdayTeacher);
            this.Controls.Add(this.buttonSchoolYearTeacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddModule);
            this.Controls.Add(this.buttonBirthdayStudent);
            this.Controls.Add(this.buttonSchoolYearStudent);
            this.Name = "Form1";
            this.Text = "School Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSchoolYearStudent;
        private System.Windows.Forms.Button buttonBirthdayStudent;
        private System.Windows.Forms.Button buttonAddModule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPromote;
        private System.Windows.Forms.Button buttonBirthdayTeacher;
        private System.Windows.Forms.Button buttonSchoolYearTeacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button teacherAddress;
        private System.Windows.Forms.Button studentAddress;
    }
}

