using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class GrownUp : ISomeone
    {
        private string Name;

        public GrownUp(string name)
        {
            this.Name = name;
        }

        public string IntroduceYourself()
        {
            return this.Name;
        }

        public string SayGoodMorning(int weekDay)
        {
            if (weekDay < 6)
            {
                return $"Oh no, {this.Name} is late for work!";
            }
            else if (weekDay == 6 || weekDay == 7)
            {
                return $"Go away, {this.Name} wants to sleep some more!";
            }
            else
            {
                return "ERROR";
            }
        }

        public string SayGoodNight(int hour)
        {
            if (hour > 23)
            {
                return $"{Name} will have trubles getting up in the morning!";
            }
            else if (hour < 24)
            {
                return $"{Name} managed for once to go to sleep on time!";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
