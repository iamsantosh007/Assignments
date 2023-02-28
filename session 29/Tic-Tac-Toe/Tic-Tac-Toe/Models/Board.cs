using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Models
{
    public class Board
    {
        private Cell[] _cells;

        public Board() { 
            _cells= new Cell[9];
            InitializeCells();
        }

        private void InitializeCells()
        {
            for(int i=0;i<_cells.Length; i++) 
            {
                _cells[i] = new Cell();
            }
        }

        public void MakeCell(int cellPosition,MarkType mark)
        {
            _cells[cellPosition].MarkType = mark;
        }

        public Cell[] Cells
        {
            get{
                return _cells;
            }
        }

       

        public bool IsEmpty()
        {
            for(int i = 0; i < 9; i++)
            {
                if (_cells[i].MarkType!=MarkType.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        internal bool VerticalMatch()
        {
            if (Cells[0].MarkType==MarkType.X && Cells[3].MarkType==MarkType.X && Cells[6].MarkType==MarkType.X || Cells[0].MarkType == MarkType.O && Cells[3].MarkType == MarkType.O && Cells[6].MarkType == MarkType.O) 
            {
                return true;
            }
            if (Cells[1].MarkType == MarkType.X && Cells[4].MarkType == MarkType.X && Cells[7].MarkType == MarkType.X || Cells[1].MarkType == MarkType.O && Cells[5].MarkType == MarkType.O && Cells[7].MarkType == MarkType.O)
            {
                return true;
            }
            if (Cells[2].MarkType == MarkType.X && Cells[5].MarkType == MarkType.X && Cells[8].MarkType == MarkType.X || Cells[2].MarkType == MarkType.O && Cells[5].MarkType == MarkType.O && Cells[8].MarkType == MarkType.O)
            {
                return true;
            }
            return false;
        }

        internal bool HorizontalMatch()
        {
            if (Cells[0].MarkType == MarkType.X && Cells[1].MarkType == MarkType.X && Cells[2].MarkType == MarkType.X || Cells[0].MarkType == MarkType.O && Cells[1].MarkType == MarkType.O && Cells[2].MarkType == MarkType.O)
            {
                return true;
            }
            if (Cells[3].MarkType == MarkType.X && Cells[4].MarkType == MarkType.X && Cells[5].MarkType == MarkType.X || Cells[3].MarkType == MarkType.O && Cells[4].MarkType == MarkType.O && Cells[5].MarkType == MarkType.O)
            {
                return true;
            }
            if (Cells[6].MarkType == MarkType.X && Cells[7].MarkType == MarkType.X && Cells[8].MarkType == MarkType.X || Cells[6].MarkType == MarkType.O && Cells[7].MarkType == MarkType.O && Cells[8].MarkType == MarkType.O)
            {
                return true;
            }
            return false;
        }

        internal bool DiagonalMatch()
        {
            if (Cells[0].MarkType == MarkType.X && Cells[4].MarkType == MarkType.X && Cells[8].MarkType == MarkType.X || Cells[0].MarkType == MarkType.O && Cells[5].MarkType == MarkType.O && Cells[8].MarkType == MarkType.O)
            {
                return true;
            }
            if (Cells[2].MarkType == MarkType.X && Cells[4].MarkType == MarkType.X && Cells[6].MarkType == MarkType.X || Cells[2].MarkType == MarkType.O && Cells[4].MarkType == MarkType.O && Cells[6].MarkType == MarkType.O)
            {
                return true;
            }
            return false;
        }

        internal bool NoFieldRemaining()
        {
            bool remainingCell = true;
            for(int i=0;i<Cells.Length;i++)
            {
                if (_cells[i].MarkType!=MarkType.Empty) 
                { 
                    remainingCell= false;
                }
            }
            return remainingCell;
        }
    }
}
