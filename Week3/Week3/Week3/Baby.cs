using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Baby : Human
    {
        private string Name;

        public Baby(string name) :base(name)
        {
            this.Name = name;
        }


        public override string SayGoodMorning(int weekDay)
        {
            return $"UUUUUU, {this.Name} is hungryyyyy";
        }

        public override string SayGoodNight(int hour)
        {
            return $"UUUUUU, {this.Name} is hungryyyyy";
        }
    }
}
