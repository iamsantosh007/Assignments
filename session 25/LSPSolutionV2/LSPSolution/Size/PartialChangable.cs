using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Size
{
    public abstract class PartialChangable : IShape
    {
        private int _height;
        private int _width;

        public PartialChangable(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public virtual int Height { get { return _height; } set { _height = value; } }
        public virtual int Width { get { return _width; } set { _width = value; } }

        public abstract int CalculateArea();
    }
}
