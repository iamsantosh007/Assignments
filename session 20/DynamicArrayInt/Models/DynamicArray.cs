using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayInt.Models
{
    public class DynamicArray
    {
        //private int _initialArraySize = 0;
        private int[] _data;
        private int _index;

        public DynamicArray(int sizeOFSize)
        {
            _data=new int[sizeOFSize];
        }

       

        public int[] Array { get { return _data; } set { _data = value; } }
        public int Index { get { return _index; } set { _index = value; } }

        public int[] GetData()
        {
            return _data;
        }
    }
}
