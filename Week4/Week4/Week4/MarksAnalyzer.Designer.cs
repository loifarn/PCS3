namespace Week4
{
    partial class MarksAnalyzer
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
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_StudentNum = new System.Windows.Forms.TextBox();
            this.TB_NewMark = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_StudentNumber = new System.Windows.Forms.Label();
            this.Label_NewMark = new System.Windows.Forms.Label();
            this.Btn_CreateStudent = new System.Windows.Forms.Button();
            this.Btn_AddMark = new System.Windows.Forms.Button();
            this.Btn_CalculateAvg = new System.Windows.Forms.Button();
            this.Label_Marks = new System.Windows.Forms.Label();
            this.Label_AvgMarks = new System.Windows.Forms.Label();
            this.RTB_Marks = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(95, 12);
            this.TB_Name.MaxLength = 25;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 0;
            this.TB_Name.DoubleClick += new System.EventHandler(this.TB_Name_DoubleClick);
            // 
            // TB_StudentNum
            // 
            this.TB_StudentNum.Location = new System.Drawing.Point(95, 38);
            this.TB_StudentNum.MaxLength = 8;
            this.TB_StudentNum.Name = "TB_StudentNum";
            this.TB_StudentNum.Size = new System.Drawing.Size(100, 20);
            this.TB_StudentNum.TabIndex = 1;
            this.TB_StudentNum.DoubleClick += new System.EventHandler(this.TB_StudentNum_DoubleClick);
            // 
            // TB_NewMark
            // 
            this.TB_NewMark.Location = new System.Drawing.Point(95, 106);
            this.TB_NewMark.Name = "TB_NewMark";
            this.TB_NewMark.Size = new System.Drawing.Size(100, 20);
            this.TB_NewMark.TabIndex = 2;
            this.TB_NewMark.DoubleClick += new System.EventHandler(this.TB_NewMark_DoubleClick);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(54, 15);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(35, 13);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Name";
            // 
            // Label_StudentNumber
            // 
            this.Label_StudentNumber.AutoSize = true;
            this.Label_StudentNumber.Location = new System.Drawing.Point(5, 41);
            this.Label_StudentNumber.Name = "Label_StudentNumber";
            this.Label_StudentNumber.Size = new System.Drawing.Size(84, 13);
            this.Label_StudentNumber.TabIndex = 4;
            this.Label_StudentNumber.Text = "Student Number";
            // 
            // Label_NewMark
            // 
            this.Label_NewMark.AutoSize = true;
            this.Label_NewMark.Location = new System.Drawing.Point(33, 109);
            this.Label_NewMark.Name = "Label_NewMark";
            this.Label_NewMark.Size = new System.Drawing.Size(56, 13);
            this.Label_NewMark.TabIndex = 5;
            this.Label_NewMark.Text = "New Mark";
            // 
            // Btn_CreateStudent
            // 
            this.Btn_CreateStudent.Location = new System.Drawing.Point(234, 9);
            this.Btn_CreateStudent.Name = "Btn_CreateStudent";
            this.Btn_CreateStudent.Size = new System.Drawing.Size(100, 23);
            this.Btn_CreateStudent.TabIndex = 6;
            this.Btn_CreateStudent.Text = "Create Student";
            this.Btn_CreateStudent.UseVisualStyleBackColor = true;
            this.Btn_CreateStudent.Click += new System.EventHandler(this.Btn_CreateStudent_Click);
            // 
            // Btn_AddMark
            // 
            this.Btn_AddMark.Location = new System.Drawing.Point(95, 132);
            this.Btn_AddMark.Name = "Btn_AddMark";
            this.Btn_AddMark.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddMark.TabIndex = 7;
            this.Btn_AddMark.Text = "Add Mark";
            this.Btn_AddMark.UseVisualStyleBackColor = true;
            this.Btn_AddMark.Click += new System.EventHandler(this.Btn_AddMark_Click);
            // 
            // Btn_CalculateAvg
            // 
            this.Btn_CalculateAvg.Location = new System.Drawing.Point(234, 162);
            this.Btn_CalculateAvg.Name = "Btn_CalculateAvg";
            this.Btn_CalculateAvg.Size = new System.Drawing.Size(128, 23);
            this.Btn_CalculateAvg.TabIndex = 8;
            this.Btn_CalculateAvg.Text = "Calculate Average";
            this.Btn_CalculateAvg.UseVisualStyleBackColor = true;
            this.Btn_CalculateAvg.Click += new System.EventHandler(this.Btn_CalculateAvg_Click);
            // 
            // Label_Marks
            // 
            this.Label_Marks.AutoSize = true;
            this.Label_Marks.Location = new System.Drawing.Point(231, 44);
            this.Label_Marks.Name = "Label_Marks";
            this.Label_Marks.Size = new System.Drawing.Size(36, 13);
            this.Label_Marks.TabIndex = 9;
            this.Label_Marks.Text = "Marks";
            // 
            // Label_AvgMarks
            // 
            this.Label_AvgMarks.AutoSize = true;
            this.Label_AvgMarks.Location = new System.Drawing.Point(231, 188);
            this.Label_AvgMarks.Name = "Label_AvgMarks";
            this.Label_AvgMarks.Size = new System.Drawing.Size(80, 13);
            this.Label_AvgMarks.TabIndex = 10;
            this.Label_AvgMarks.Text = "Average Mark: ";
            // 
            // RTB_Marks
            // 
            this.RTB_Marks.Location = new System.Drawing.Point(234, 60);
            this.RTB_Marks.Name = "RTB_Marks";
            this.RTB_Marks.Size = new System.Drawing.Size(128, 96);
            this.RTB_Marks.TabIndex = 11;
            this.RTB_Marks.Text = "";
            // 
            // MarksAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 220);
            this.Controls.Add(this.RTB_Marks);
            this.Controls.Add(this.Label_AvgMarks);
            this.Controls.Add(this.Label_Marks);
            this.Controls.Add(this.Btn_CalculateAvg);
            this.Controls.Add(this.Btn_AddMark);
            this.Controls.Add(this.Btn_CreateStudent);
            this.Controls.Add(this.Label_NewMark);
            this.Controls.Add(this.Label_StudentNumber);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.TB_NewMark);
            this.Controls.Add(this.TB_StudentNum);
            this.Controls.Add(this.TB_Name);
            this.Name = "MarksAnalyzer";
            this.Text = "MarksAnalyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_StudentNum;
        private System.Windows.Forms.TextBox TB_NewMark;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_StudentNumber;
        private System.Windows.Forms.Label Label_NewMark;
        private System.Windows.Forms.Button Btn_CreateStudent;
        private System.Windows.Forms.Button Btn_AddMark;
        private System.Windows.Forms.Button Btn_CalculateAvg;
        private System.Windows.Forms.Label Label_Marks;
        private System.Windows.Forms.Label Label_AvgMarks;
        private System.Windows.Forms.RichTextBox RTB_Marks;
    }
}