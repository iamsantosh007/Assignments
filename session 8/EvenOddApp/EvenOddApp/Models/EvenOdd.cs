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
            //float bound = (float)range / 2;
            int indexNum = 0;
            EvenNum = new int[range/2];
            for(int i=1;i<=range; i++)
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
            float bound = (float)range / 2;
            if (range % 2 != 0)
                bound= ((float)range / 2)+0.5f;
            int indexNum = 0;
            OddNum = new int[(int)bound];
            for (int i = 0; i <=range; i++)
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
