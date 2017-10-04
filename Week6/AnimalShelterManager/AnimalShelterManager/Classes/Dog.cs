using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManager.Classes
{
    [Serializable]
    class Dog : Animal
    {
        private DateTime LastWalk;

        public Dog(int regNum, DateTime brought, string name, DateTime lastWalk) : base(regNum, brought, name)
        {
            this.LastWalk = lastWalk;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.ChipNumber}, {this.DateBrought.ToShortDateString()}, {this.GetPrice()} euros and last walk-date is: {this.LastWalk}";
        }

        public override int GetPrice()
        {
            //Pre-coded
            DateTime today = DateTime.Now;
            TimeSpan ts = today.Subtract(this.DateBrought);
            int daysAtShelter = ts.Days;

            return 10 + (5 * ts.Days);
        }

        private void TakeForAWalk()
        {
            LastWalk = DateTime.Now;
        }
    }
}
