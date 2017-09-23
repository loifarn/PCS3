using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Baby : ISomeone
    {
        private string Name;

        public Baby(string name)
        {
            this.Name = name;
        }

        public string IntroduceYourself()
        {
            return this.Name;
        }

        public string SayGoodMorning(int weekDay)
        {
            return $"UUUUUU, {this.Name} is hungryyyyy";
        }

        public string SayGoodNight(int hour)
        {
            return $"UUUUUU, {this.Name} is hungryyyyy";
        }
    }
}
