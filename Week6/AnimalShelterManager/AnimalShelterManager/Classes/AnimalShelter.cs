using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Self-written
using AnimalShelterManager.Exceptions;
using System.ComponentModel;

namespace AnimalShelterManager.Classes
{
    
    class AnimalShelter
    {
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public BindingList<Animal> OurAnimals { get; set; }

        public AnimalShelter(string name, string telephoneNumber)
        {
            OurAnimals = new BindingList<Animal>();
            this.Name = name;
            this.TelephoneNumber = telephoneNumber;
        }

        public void AddAnimal(int regNumber, string animal, DateTime brought, string name, DateTime lastWalk)
        {
            if (animal.Equals("dog"))
            {
                OurAnimals.Add(new Dog(regNumber, brought, name, lastWalk));
                MessageBox.Show("New animal added");
            }
            else
            {
                throw new AnimalCreationException();
            }
        }
        //Overloading
        public void AddAnimal(int regNumber, string animal, DateTime brought, string name, string badHabit)
        {
            try
            {
                if (animal.Equals("cat") && !OurAnimals.Any(Animal => Animal.ChipNumber.Equals(regNumber)))
                {
                    OurAnimals.Add(new Cat(regNumber, brought, name, badHabit));
                    MessageBox.Show("New animal added");
                }
                else
                {
                    throw new AnimalCreationException();
                }
            }
            catch(AnimalCreationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Animal FindAnimal(int regNumber)
        {
            return OurAnimals[OurAnimals.IndexOf(OurAnimals.First(Animal => Animal.ChipNumber.Equals(regNumber)))];
        }

        public void Removeanimal(int regNumber)
        {
            OurAnimals.RemoveAt(OurAnimals.IndexOf(OurAnimals.First(Animal => Animal.ChipNumber.Equals(regNumber))));
        }

        public void listAnimals(ListBox listBox)
        {
            listBox.DataSource = OurAnimals;
        }
        public void ListDogs(ListBox listBox)
        {
            BindingList<Dog> dogs = new BindingList<Dog>();
            foreach (var dog in OurAnimals.OfType<Dog>())
            {
                dogs.Add(dog);
            }
            listBox.DataSource = dogs;
        }

    }
}
