using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManager.Classes
{
    [Serializable]
    class Cat : Animal
    {
        private string BadHabit;

        public Cat(int regNum, DateTime brought, string name, string badHabit) : base(regNum, brought, name)
        {
            this.BadHabit = badHabit;
        }

        public override string ToString()
        {
            if(BadHabit.Equals("") || BadHabit.Equals(null))
            {
                return $"{this.GetType().Name}: {this.ChipNumber}, {this.DateBrought.ToShortDateString()}, {this.GetPrice()} euros and no bad habits";
            }
            else
            {
                return $"{this.GetType().Name}: {this.ChipNumber}, {this.DateBrought.ToShortDateString()}, {this.GetPrice()} euros and bad habits: {this.BadHabit}";
            }
        }

        public override int GetPrice()
        {
            if(BadHabit.Equals(""))
            {
                return 30;
            }
            else
            {
                return 50;
            }
        }
    }
}
