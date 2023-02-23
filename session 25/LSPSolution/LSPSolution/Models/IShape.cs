using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Models
{
    public interface IShape
    {
        public abstract int Height { get; set; }
        public abstract int Width { get; set; }
        int CalculateArea();
    }
}
