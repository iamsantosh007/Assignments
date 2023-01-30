using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddApp.Models
{
    class EvenOdd
    {
        private int[] _evenNum;
        private int[] _oddNum;

        public  int[] EvenNum { 
            get { return _evenNum; } 
            set { _evenNum = value; } 
        }

        public int[] OddNum { get { return _oddNum; } set { _oddNum = value; } }

        public void EvenNumGenerator(int range)
        {
            int indexNum = 0;
            EvenNum = new int[range/2];
            for(int i=0;i<range; i++)
            {
                if (i % 2 == 0)
                {
                    EvenNum[indexNum] = i;
                    indexNum++;
                }
            }
            
        }

        public void OddNumGenerator(int range)
        {
            int indexNum = 0;
            OddNum = new int[range / 2];
            for (int i = 0; i < range; i++)
            {
                if (i % 2 != 0)
                {
                    OddNum[indexNum] = i;
                    indexNum++;
                }
            }
           
        }
    }
}
