using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayGenericApp.Models
{
    public class DynamicArray<T>
    {
        private T[] _array;
        private int _index;

        public DynamicArray(int sizeOfArray)
        {
            _array= new T[sizeOfArray];
        }

       

        public T[] GetData()
        {
            return _array;
        }

        public T[] Array { get { return _array; }set { _array = value; } }
        public int Index { get { return _index; } set { _index = value; } }



    }
}
