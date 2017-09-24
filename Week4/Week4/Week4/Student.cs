﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Student
    {
        private string Name;
        private int StNumber;
        private List<int> marks;

        public Student(string name, int stNr)
        {
            this.Name = name;
            this.StNumber = stNr;
            marks = new List<int>();
        }

        public void AddMark(int mark) => marks.Add(mark);

        public int CalculateAverageMark() => (int)marks.Average();
    }
}
