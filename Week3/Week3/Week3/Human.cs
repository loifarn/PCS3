using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    abstract class Human : ISomeone
    {
        private string Name;
        public Human(string name)
        {
            this.Name = name;
        }

        public string IntroduceYourself()
        {
            return this.Name;
        }

        public abstract string SayGoodMorning(int weekDay);

        public abstract string SayGoodNight(int hour);
    }
}
