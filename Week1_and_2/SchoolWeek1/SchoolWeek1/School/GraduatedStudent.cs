using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class GraduatedStudent : Person
    {
        private int YearOfGraduation;
        private double GraduationMark;

        public GraduatedStudent(int yearOfGraduation, double graduationMark, string name, string address, int pcn, int age) : base(name, address, pcn, age)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.Address = address;
            this.YearOfGraduation = yearOfGraduation;
            this.GraduationMark = graduationMark;
        }
    }
}
