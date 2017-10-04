using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterManager.Exceptions
{
    class AnimalCreationException : Exception
    {
        public AnimalCreationException() : base("Animal allready exists")
        {
            //Empty body
        }
    }
}
