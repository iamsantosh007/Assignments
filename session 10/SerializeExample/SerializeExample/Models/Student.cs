using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerializeExample.Models
{
    [Serializable]
   public class Student
    {
        private string _name;
        private int _age;

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
    }
}
