using DynamicArrayGenericApp.Models;
using System;

namespace DynamicArrayGenericApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<string> dynamicArray = new DynamicArray<string>(2);
            bool start = true;
            while (start)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t\t\t Array Size count is {dynamicArray.GetData().Length}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1-Add\n" +
                    "2-Display\n" +
                    "3-show Type\n" +
                    "4-Exit");
                Console.ResetColor();
                Console.Write("Enter your choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddArray(dynamicArray);
                        break;
                    case 2:
                        DisPlayArray(dynamicArray); break;
                    case 3:
                        Console.WriteLine(dynamicArray.GetType());
                        break;
                    case 4:
                        start = false;
                        break;


                }
            }
        }

        private static void DisPlayArray<T>(DynamicArray<T> dynamicArray)
        {

           T[] array= dynamicArray.GetData();
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void AddArray<T>(DynamicArray<T> dynamicArray)
        {
            Console.WriteLine("enter value:- ");
            string input = Console.ReadLine();
            T data = (T)Convert.ChangeType(input,typeof(T));
            if (IsIncreasedArray(dynamicArray))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tYou increases the array and add the value");
                Console.ResetColor();
            }
            dynamicArray.Array[dynamicArray.Index] = data;
            dynamicArray.Index++;
        }
        private static bool IsIncreasedArray<T>(DynamicArray<T> dynamicArray)
        {
            if (dynamicArray.Index == dynamicArray.Array.Length)
            {
                T[] arrayUpdated = new T[dynamicArray.Array.Length + 1];
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