using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Models
{
    public class FileSystem : IStorageItem
    {
        //private string _name;
        //private int _space;

        private int _size;
        
        public string Name { get; set; }
        public int Space { get; set; }
        public int Size { get { return _size; } set { _size = value; } } 

        public void Display()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            for (int i = 0; i <Space; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine($"{Space}) The Name of file is{Name} and Size is {Size}MB");
            Console.ResetColor();
        }
    }
}
