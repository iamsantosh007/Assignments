using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Size;

namespace LSPSolution.Models
{
    public class Rectanglee:PartialChangable
    {
        public Rectanglee(int height, int width):base(height,width)
        {
    
        }

        //public override int Height { get { return _height; } set { _height = value; } }
        //public override int Width { get { return _width; } set { _width = value; } }

        public override int CalculateArea()
        {
            return Width * Height;
        }

    }
}
