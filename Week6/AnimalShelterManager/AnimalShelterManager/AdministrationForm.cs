using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Self-written
using AnimalShelterManager.Classes;
using AnimalShelterManager.Exceptions;

namespace AnimalShelterManager
{
    public partial class AdministrationForm : Form
    {
        private AnimalShelter animalShelter;
        public AdministrationForm()
        {
            InitializeComponent();
            animalShelter = new AnimalShelter("Best Animal Shelter", "111 222 333");
        }

        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
            int chipNum;

            try
            {
                chipNum = Convert.ToInt32(tbChipNr.Text);

                if (rbDog.Checked == true)
                {
                    animalShelter.AddAnimal(chipNum, "dog", dtpDateBroughtIn.Value, tbName.Text, dtpLastWalkInThePark.Value.Date);
                }
                else if (rbCat.Checked == true)
                {
                    animalShelter.AddAnimal(chipNum, "cat", dtpDateBroughtIn.Value, tbName.Text, tbExtraCatInfo.Text);
                }
                else
                {
                    throw new AnimalCreationException();
                }
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("You must enter an integer value for the chip number!");
            }
        }

        private void btnShowInfoAllAnimals_Click(object sender, EventArgs e)
        {
            animalShelter.listAnimals(listBoxAnimals);
        }

        private void btnShowInfoDogs_Click(object sender, EventArgs e)
        {
            animalShelter.ListDogs(listBoxAnimals);
        }

        private void btnRemoveAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                animalShelter.Removeanimal(Convert.ToInt32(tbRemoveChipNr.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("You must enter an integer value for the chip number!");
            }
        }
    }
}
