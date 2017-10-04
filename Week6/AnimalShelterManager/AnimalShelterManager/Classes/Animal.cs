using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManager.Classes
{
    [Serializable]
    abstract class Animal
    {
        public int ChipNumber { get; set; }
        protected DateTime DateBrought { get; set; }
        protected string Name { get; set; }

        public Animal (int chipNum, DateTime brought, string name)
        {
            this.ChipNumber = chipNum;
            this.DateBrought = brought;
            this.Name = name;
        }

        public override abstract string ToString();

        public abstract int GetPrice();
    }
}
