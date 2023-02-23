using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Size;

namespace LSPSolution.Models
{
    public class Square : FullChangable
    {
        public Square(int side):base(side)
        {
         
        }

        //public override int Height
        //{
        //    get { return Height; }
        //    set { Height=Width= value; }
        //}

        //public override int Width
        //{
        //    get { return Width; }
        //    set {Height=Width= value; }
        //}

        public override int CalculateArea()
        {
            return Height * Width;
        }
    }
}
