using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Person
    {
        private string _name;
        private int _pcn;
        private int _age;
        private int _yearsAtfontys;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int PCN
        {
            get { return _pcn; }
            set { _pcn = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int YearsAtFontys
        {
            get { return _yearsAtfontys; }
            set { _yearsAtfontys = value; }
        }


        public Person(string name, int pcn, int age)
        {
            this._name = name;
            this._pcn = pcn;
            this._age = age;
        }

        public void CelebrateBirthday()
        {

        }

        public void StartAnotherSchoolYear()
        {

        }


    }
}
