using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class MPA_Form : Form
    {
        private Logic logic;
        private List<Person> personList;
        public MPA_Form()
        {
            InitializeComponent();
            personList = new List<Person>();
            logic = new Logic(LB_Display);
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if(Field_Name.Text.Length > 0 && Field_PCN.Text.Length > 0 && Field_Age.Text.Length > 0)
            {
                try
                {
                    logic.AddPerson(Field_Name.Text, Convert.ToInt32(Field_PCN.Text), Convert.ToInt32(Field_Age.Text));
                } catch(FormatException ex)
                {
                    MessageBox.Show("Name = Letters only, PCN = numbers only, Age = Numbers only");
                }
                //needs way more tests to be safe
                
            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            logic.DeletePerson();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            logic.EditPerson();
            /*
            string[] vals = (LB_Display.SelectedItem.ToString()).Split('|');
            Field_Name.Text = vals[0];
            Field_PCN.Text = vals[1];
            Field_Age.Text = vals[2];*/
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();

            logic.LoadFile(ofd.FileName.ToString());
            LBL_CurrentFile.Text = $"File: {ofd.FileName}";
        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = svd.ShowDialog();
            logic.SaveFile(svd.FileName);
            LBL_CurrentFile.Text = $"File: {svd.FileName}";
        }
    }
}
