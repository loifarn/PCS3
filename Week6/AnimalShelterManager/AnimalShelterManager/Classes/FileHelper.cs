using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManager.Classes
{
    class FileHelper
    {
        private string FileName;

        public FileHelper(string fileName)
        {
            this.FileName = fileName;
        }

        public void SaveToFile(BindingList<Animal> animals)
        {
            try
            {
                using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, animals);
                }
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Error writing to file");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("No file selected");
            }
        }
        public BindingList<Animal> LoadFromFile()
        {
            BindingList<Animal> animals = new BindingList<Animal>();
            try
            {
                using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    animals = (BindingList<Animal>)bf.Deserialize(fs);
                }
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Error loading file");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No file selected");
            }
            return animals;
        }
    }
}
