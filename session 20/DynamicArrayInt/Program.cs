using DynamicArrayInt.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DynamicArrayInt
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            DynamicArray dynamicArray = new DynamicArray(2);
            bool start=true;
            while (start)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\tInt Array Size count is {dynamicArray.GetData().Length}");
                Console.ResetColor();

                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("1-Add\n" +
                    "2-Display\n" +
                    "3-Exit");
                Console.ResetColor();
                Console.Write("Enter your choice:- ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddInt(dynamicArray);
                        break;
                    case 2:
                        DisPlayIntArray(dynamicArray); break;
                        case 3:
                        start= false;
                        break;


                }
            }

            
            
        }

        private static void DisPlayIntArray(DynamicArray dynamicArray)
        {
            Console.Write("\t\t\tThe element of array is:-");
            int[] resultGot = dynamicArray.GetData();
            foreach(int i in resultGot)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        private static void AddInt(DynamicArray dynamicArray)
        {
            Console.Write("Enter number:- ");
            int addNum=Convert.ToInt32(Console.ReadLine());
            if (IsIncreaseSize(dynamicArray))
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tyou increases the array and add the value");
                Console.ResetColor();

            }

            for (int i = 0; i < dynamicArray.Array.Length; i++)
            {
                if (dynamicArray.Array[i] == 0 && addNum > 0)
                {
                    dynamicArray.Array[i] = addNum;
                    dynamicArray.Index = i + 1;
                    return;
                }
                if (dynamicArray.Array[i] == 0 && addNum == 0)
                {
                    dynamicArray.Array[i] = addNum;
                    dynamicArray.Index = i + 1;
                    return;
                }

            }
        }

        private static bool IsIncreaseSize(DynamicArray dynamicArray)
        {
            if (dynamicArray.Index == dynamicArray.Array.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\t\tThe initial lenght of array is {dynamicArray.Array.Length} and you add the data beyond that");
                Console.ResetColor();
                int[] arrayUpdated = new int[dynamicArray.Index + 1];
                for (int i = 0; i < dynamicArray.Array.Length; i++)
                {
                    arrayUpdated[i] = dynamicArray.Array[i];
                }
                dynamicArray.Array = arrayUpdated;
                return true;
            }
            return false;
        }
    }
}