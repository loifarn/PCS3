using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private string name;
        private int pcn;
        private int age;
        private int yearsAtFontys;
        private string country;
        private int ec;

        public Student(string name, int pcn, int age, string country) {
            this.name = name;
            this.pcn = pcn;
            this.age = age;
            this.country = country;
        }

        public void StartAnotherSchoolYear()
        {
            yearsAtFontys++;
        }

        public void CelebrateBirthday()
        {
            age++;
        }

        public string InfoString()
        {
            return $"{name} {pcn}\nAge: {age}, {yearsAtFontys} years at Fontys\nCountry: {country}\nEC's: {ec}";
        }

        public void AddOneModuleEC()
        {
            ec+=3;
        }

    }
}
