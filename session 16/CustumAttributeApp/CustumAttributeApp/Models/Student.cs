using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumAttributeApp.Models
{
    public class Student
    {
        private int _id;
        private string _name;

        public Student(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public void M1()
        {
            Console.WriteLine($"Id is {_id} and name is {_name}");
        }

        [RefectoredAttribute]
        public void M2()
        {
            Console.WriteLine($"welcome to student app mr.{Name}");
        }
    }
}
