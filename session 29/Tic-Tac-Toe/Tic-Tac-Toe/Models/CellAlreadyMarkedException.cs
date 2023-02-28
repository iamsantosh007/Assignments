using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Models
{
    public class CellAlreadyMarkedException:Exception
    {
        public override string Message
        {
            get { return "cell is already marked"; }
        }
    }
}
