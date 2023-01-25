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

        public string Name
        {
            get { return _name; }

            set
            {

                if (value.Length >= 5)
                    _name = value;
            }
        }

        public float CGPA { 
            get { return _cgpa; } 
            set { 
                if(value>=1 && value<=10)
                    _cgpa = value;
            } 
        }

        public float GetPercentage(float studentPercentage)
        {
            return (float)((7.2 * studentPercentage) + 11);

        }
    }
}
