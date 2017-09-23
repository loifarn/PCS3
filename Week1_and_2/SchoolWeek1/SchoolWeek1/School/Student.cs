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

        public Student(string name, string address, int pcn, int age, string country) :base(name, address, pcn, age ){
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.Country = country;
            this.Address = address;
        }

        public override string InfoString()
        {
            return $"{Name} ({PCN})\nAge: {Age}, {YearsAtFontys} years at Fontys\nAddress: {Address}\nCountry: {Country}\nEC's: {ec}";
        }

        public void AddOneModuleEC()
        {
            ec+=3;
        }
    }
}
