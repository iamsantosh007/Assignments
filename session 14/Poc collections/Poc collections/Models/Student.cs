using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc_collections.Models
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _age;

        public Student(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }

        public int Id { get { return _id;} }
        public string Name { get { return _name;} }
        public int Age { get { return _age; } }
    }
}
