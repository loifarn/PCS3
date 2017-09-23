using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class FamilyForm : Form
    {
        private List<ISomeone> myFamily = new List<ISomeone>();

        public FamilyForm()
        {
            InitializeComponent();

            myFamily.Add(new Baby("Timmy"));
            myFamily.Add(new GrownUp("John"));
            myFamily.Add(new Dog(5));

            for (int i = 0; i < myFamily.Count; i++)
            {
                familyListBox.Items.Add(myFamily[i].IntroduceYourself());
            }
            familyListBox.SetSelected(0, true); //Sets selected to avoid crash
        }

        private void Btn_morning_Click(object sender, EventArgs e)
        {
            //Will crash program is nothing is selected in listbox.
            morningLabel.Text = $"{myFamily[familyListBox.SelectedIndex].SayGoodMorning(Convert.ToInt16(Dial_days.Value))}";
        }

        private void Btn_night_Click(object sender, EventArgs e)
        {
            nightLabel.Text = $"{myFamily[familyListBox.SelectedIndex].SayGoodNight(Convert.ToInt16(Dial_hours.Value))}";
        }
    }
}
