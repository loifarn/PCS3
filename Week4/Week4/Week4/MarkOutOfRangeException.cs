using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class MarkOutOfRangeException : Exception
    {
        public MarkOutOfRangeException() :base("Mark value is out of range")
        {
            //empthy body
        }
    }
}
