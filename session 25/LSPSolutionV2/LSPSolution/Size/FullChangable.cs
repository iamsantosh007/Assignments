using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Size
{
    public abstract class FullChangable : IShape
    {
        private int _height;
        private int _width;

        public FullChangable(int side)
        {
            _height = side;
            _width = side;
        }
        public virtual int Height { get { return _height; } set { _height=_width = value; } }
        public virtual int Width { get { return _width; } set { _width=_height = value; } }

        public abstract int CalculateArea();
    }
}
