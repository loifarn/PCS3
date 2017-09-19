using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Person
    {

        protected string Name;
        protected int PCN;
        protected int Age;
        protected int YearsAtFontys;

        public Person(string name, int pcn, int age)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
        }


        public void StartAnotherSchoolYear()
        {
            YearsAtFontys++;
        }

        public void CelebrateBirthday()
        {
            Age++;
        }
    }
}
