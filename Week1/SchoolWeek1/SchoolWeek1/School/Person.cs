using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Person
    {

        private string name;
        private string person;
        private string pcn;
        private int age;
        private int yearsAtFontys;

        public Person(string name, string pcn, int age)
        {
            this.name = name;
            this.pcn = pcn;
            this.age = age;
        }


        public void StartAnotherSchoolYear()
        {
            yearsAtFontys++;
        }

        public void CelebrateBirthday()
        {
            age++;
        }
    }
}
