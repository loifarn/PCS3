using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        private string Country;
        private int ec;

        public Student(string name, int pcn, int age, string country) :base(name, pcn, age ){
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.Country = country;
        }

        public string InfoString()
        {
            return $"{Name} ({PCN})\nAge: {Age}, {YearsAtFontys} years at Fontys\nCountry: {Country}\nEC's: {ec}";
        }

        public void AddOneModuleEC()
        {
            ec+=3;
        }

    }
}
