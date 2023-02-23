using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Size
{
    public interface IShape
    {
        public abstract int Height { get; set; }
        public abstract int Width { get; set; }
        public abstract int CalculateArea();
    }
}
