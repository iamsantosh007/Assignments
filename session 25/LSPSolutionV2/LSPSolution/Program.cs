using LSPSolution.Models;
using LSPSolution.Size;
using System.Drawing;

namespace LSPSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectanglee rectangle = new Rectanglee(10, 20);
            Square square = new Square(10);
            HeightShouldNotChangedAfterWidtgModification(rectangle);
           CalculateArea(rectangle);
            HeightShouldChangedAfterWidtgModification(square);
            HeightShouldNotChangedAfterWidtgModification(rectangle);
            CalculateArea(square);
        }

        private static void HeightShouldChangedAfterWidtgModification(FullChangable shape)
        {
            int beforUpdateHeight = shape.Height+20;
            shape.Width = shape.Width + 20;
            int afterUpdateHeight = shape.Height;
            Console.WriteLine(beforUpdateHeight == afterUpdateHeight);
        }

        private static void HeightShouldNotChangedAfterWidtgModification(PartialChangable shape)
        {
            int beforUpdateHeight = shape.Height;
            shape.Width = shape.Width + 20;
            int afterUpdateHeight = shape.Height;
            Console.WriteLine(beforUpdateHeight == afterUpdateHeight);
        }

        private static void CalculateArea(IShape shape)
        {
            Console.WriteLine($"The {shape.GetType().Name} area is "+shape.CalculateArea());
        }
    }
}