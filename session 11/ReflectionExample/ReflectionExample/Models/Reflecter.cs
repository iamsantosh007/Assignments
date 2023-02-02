using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample.Models
{
    class Reflecter
    {
        private int _number;
        public Reflecter(int number)
        {
            this._number = number;
        }

        public int Number { get { return _number;} }    

        public int GetSquare()
        {
            return Number * Number;
        }
    }
}
