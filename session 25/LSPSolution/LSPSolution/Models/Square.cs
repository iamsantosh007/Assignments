using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Models
{
    public class Square : IShape
    {
        public int _side;
        public Square(int side)
        {
            _side= side;
        }

        public int Height
        {
            get { return _side; }
            set { _side = value; }
        }

        public int Width
        {
            get { return _side; }
            set { _side = value; }
        }

        public int CalculateArea()
        {
            return Height * Width;
        }
    }
}
