using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    enum Function { JUNIOR_DOCENT, DOCENT_1, DOCENT_2, INTERNSHIP_COORDINATOR, TEAM_LEADER, DIRECTOR }

    class Teacher : Person
    {
        private Function function;     // function. E,g, DOCENT_1, DOCENT_2, TEAM_LEADER, ...
        private double salary;         // monthly salary 

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Function Function
        {
            get { return function; }
            set { function = value; }
        }

        /// <summary>
        /// The only constructor.</summary>
        /// <param name="name">Initial name of the teacher.</param>
        /// <param name="pcn">Personal Fontys number of the teacher.</param>
        /// <param name="age">Age of the teacher.</param>
        /// <param name="function">Function of the teacher.</param>
        /// <param name="salary">Monthly salary of the teacher.</param>
        public Teacher(string name, string address, int pcn, int age, Function function, int salary) :base(name, address, pcn, age )
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.YearsAtFontys = 0;
            this.Function = function;
            this.Salary = salary;
            this.Address = address;
        }

        /// <summary>
        /// Returns values of all properties in the following string format:
        /// "John Doe (12456)
        ///  age 45, 15 years at Fontys
        ///  function: DOCENT_1
        ///  salary:   15000"
        /// </summary>
        public string InfoString()
        {
            string info = "";
            info += this.Name + " (" + this.PCN.ToString() + ")";
            info += "\nage " + this.Age.ToString() + ", " + this.YearsAtFontys.ToString() + " years at Fontys";
            info += $"\nAddress: {Address}";
            info += "\nfunction:\t" + this.Function.ToString();
            info += "\nsalary:\t" + this.Salary.ToString();

            return info;
        }

        /// <summary>
        /// Promotes the teacher by one function. 
        /// For example, DOCENT_1 is promoted into DOCENT_2.
        /// </summary>
        public void Promote()
        {
            if (function < Function.DIRECTOR)
                function++;
        }

        public override void StartAnotherSchoolYear()
        {
            base.StartAnotherSchoolYear();
            if (YearsAtFontys % 3 == 0)
            {
                salary = salary * 1.1;
            }
        }
    }
}
