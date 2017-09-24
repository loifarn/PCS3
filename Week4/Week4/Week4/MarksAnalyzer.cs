using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class MarksAnalyzer : Form
    {
        //private List<Student> students;
        private Student student;

        public MarksAnalyzer()
        {
            InitializeComponent();
            //students = new List<Student>(); //Should probably be a list so we can have multiple students...
        }

        private void Btn_CreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                //students.Add(new Student(TB_Name.Text, Convert.ToInt32(TB_StudentNum.Text))); //example of adding to list
                student = new Student(TB_Name.Text, Convert.ToInt32(TB_StudentNum.Text));
                MessageBox.Show("Student created");
            }
            catch (FormatException ex)
            {
                TB_Name.Text = "NAME ONLY";
                TB_StudentNum.Text = "NUMBERS ONLY";
            }
        }

        private void Btn_AddMark_Click(object sender, EventArgs e)
        {
            try
            {
                student.AddMark(Convert.ToInt32(TB_NewMark.Text));
                RTB_Marks.Text += $"{TB_NewMark.Text}\n";
            }
            catch (FormatException ex)
            {
                if (student == null)
                    MessageBox.Show("Add student first!");
                else
                    TB_NewMark.Text = "NUMBERS ONLY";
            }
            
        }

        private void Btn_CalculateAvg_Click(object sender, EventArgs e)
        {
            try
            {
                Label_AvgMarks.Text = $"Average Mark is: {student.CalculateAverageMark()}";
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("No marks have been added");
            }
            
        }

        private void TB_Name_DoubleClick(object sender, EventArgs e)
        {
            TB_Name.Clear();
        }

        private void TB_StudentNum_DoubleClick(object sender, EventArgs e)
        {
            TB_StudentNum.Clear();
        }

        private void TB_NewMark_DoubleClick(object sender, EventArgs e)
        {
            TB_NewMark.Clear();
        }


    }
}
