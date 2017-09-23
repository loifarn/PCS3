using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Dog : ISomeone
    {
        private int Age;

        public Dog(int age)
        {
            this.Age = age;
        }

        public string IntroduceYourself()
        {
            return $"Waf! I am {this.Age * 7} years old!";
        }

        public string SayGoodMorning(int weekDay)
        {
            return "Waf, wake up, take me out for a walk!";
        }

        public string SayGoodNight(int hour)
        {
            if (hour < 23)
            {
                return "Waf, I want to sleep in your bed!";
            }
            else if (hour > 22)
            {
                return "Waf, wake up, take me out for a walk!";
            }
            else
            {
                return "ERROR";
            }

        }
    }
}
