using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumAttributeV2.Models
{
    public class ClassA
    {
        [MethodLevel]
        public bool M1(int num1,int num2)
        {
            return (num1 == num2);
        }
        [MethodLevel]
        public bool M2(int num1,int num2) 
        { 
            return (num1> num2);
        }
        [MethodLevel]
        public bool M3(int num1,int num2) 
        {
            return (num1<num2);
        }
        [MethodLevel]
        public bool M4(int num1,int num2)
        {
            return(num1!=num2);
        }
    }
}
