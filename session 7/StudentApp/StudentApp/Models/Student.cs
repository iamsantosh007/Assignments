using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Student
    {
        private int _rollNo;
        private string _name;
        private float _cgpa;
        private const float _totalFees = 10000f;
        private float _remainingFees=_totalFees;

        
        public int RollNo
        {
            get { return _rollNo; }
            set
            {
                if (value > 0)
                {
                    _rollNo = value;
                }

            }
        }
      public float TotalFees { get { return _totalFees; } }

        public string Name
        {
            get { return _name; }

            set
            {

                if (value.Length >= 5)
                    _name = value;
            }
        }

        public float CGPA
        {
            get { return _cgpa; }
            set
            {
                if (value >= 1 && value <= 10)
                    _cgpa = value;
            }
        }
        public float RemainingFees { 
            get { return _remainingFees; } 
            set { 
                ValidateAmount(value,ref _remainingFees); 
            } 
        }
        public static void ValidateAmount(float amount,ref float _remainingFees)
        {
            if(amount<=_totalFees && amount<=_remainingFees)
            {
                _remainingFees-=amount;
            }
           
        }

        public float GetPercentage(float studentPercentage)
        {
            return (float)((7.2 * studentPercentage) + 11);

        }

        public float PayFees(float feeAmount)
        {
           return RemainingFees = feeAmount;
        }
    }
}
