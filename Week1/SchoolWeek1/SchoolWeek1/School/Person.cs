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
        protected string Address;
        protected int PCN;
        protected int Age;
        protected int YearsAtFontys;

        public Person(string name, string address, int pcn, int age)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.Address = address;
        }


        public void StartAnotherSchoolYear()
        {
            YearsAtFontys++;
        }

        public void CelebrateBirthday()
        {
            Age++;
        }
        public virtual string getAddress()
        {
            return this.Address;
        }
    }
}
