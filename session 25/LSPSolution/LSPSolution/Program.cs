using LSPSolution.Models;
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
            HeightShouldNotChangedAfterWidtgModification(square);
            //CalculateArea(rectangle);
            //HeightShouldChangedAfterWidtgModification(square);
            //CalculateArea(square);
        }

        private static void HeightShouldChangedAfterWidtgModification(Square square)
        {
            //Console.WriteLine($"width {square.Width} and height is {square.Height}");
            int beforUpdateHeight = square.Height+20;
            square.Width = square.Width + 20;
            int afterUpdateHeight = square.Height;
           //Console.WriteLine($"width {square.Width} and height is {square.Height}");

            Console.WriteLine(beforUpdateHeight == afterUpdateHeight);
        }

        private static void HeightShouldNotChangedAfterWidtgModification(IShape shape)
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