using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Models
{
    internal class InvalidSelection:Exception
    {
        public InvalidSelection(string message):base(message)
        {

        }
    }
}
