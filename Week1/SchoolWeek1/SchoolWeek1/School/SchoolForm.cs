using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        private Teacher teacher;
        private Student student;


        public Form1()
        {
            InitializeComponent();
            teacher = new Teacher("Edna Krabappel", "road 1234", 111111, 36, Function.DOCENT_1, 1500); // create a teacher
            student = new Student("Bob Burger", "road 412", 222222, 42, "America");
            LogTeacherChange("start");
            LogStudentChange("start");

            labelStudent.Text = student.InfoString();
            labelTeacher.Text = teacher.InfoString();
        }


        private void LogTeacherChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** " + operationName);
            this.richTextBoxLog.AppendText("\n"+teacher.InfoString());
        }

        private void LogStudentChange(string operationName)
        {
            this.richTextBoxLog.AppendText("\n*********************** "+ operationName);
            this.richTextBoxLog.AppendText("\n" + student.InfoString());
        }


        private void buttonSchoolYearTeacher_Click(object sender, EventArgs e)
        {
            teacher.StartAnotherSchoolYear();
            LogTeacherChange("another school year");
        }

        private void buttonBirthdayTeacher_Click(object sender, EventArgs e)
        {
            teacher.CelebrateBirthday();
            LogTeacherChange("birthday");
        }

        private void buttonPromote_Click(object sender, EventArgs e)
        {
            teacher.Promote();
            LogTeacherChange("promotion");
        }

        private void buttonSchoolYearStudent_Click(object sender, EventArgs e)
        {
            student.StartAnotherSchoolYear();
            LogStudentChange("another school year");
        }

        private void buttonBirthdayStudent_Click(object sender, EventArgs e)
        {
            student.CelebrateBirthday();
            LogStudentChange("birthday");
        }

        private void buttonAddModule_Click(object sender, EventArgs e)
        {
            student.AddOneModuleEC();
            LogStudentChange("module EC");
        }

        private void teacherAddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teacher address: "+ teacher.getAddress());
        }

        private void studentAddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student address: " + student.getAddress());
        }
    }
}
