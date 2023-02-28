using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Models
{
    public class Cell
    {
        private MarkType _markType;

        public Cell() 
        {
            _markType = MarkType.Empty;
        }

        public Cell(MarkType markType)
        {
            _markType = markType;
        }

        public MarkType MarkType { get { return _markType; } 
            set {
                if (!IsAlreadyMarked())
                {
                    _markType= value;
                    return;
                }
                throw new CellAlreadyMarkedException();
            } }

        public bool IsAlreadyMarked()
        {
            return _markType != MarkType.Empty;
        }

        
    }
}
