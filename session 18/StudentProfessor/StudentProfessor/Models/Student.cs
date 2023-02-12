using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessor.Models
{
    public enum branches { Bsc_It,MCA,BE}
    class Student:Person
    {
        private branches _branch;
        public Student(int id,string address, int dob,branches branch) : base(id, address, dob)
        {
            this._branch = branch;
        }

        public branches PrintDetails()
        {
            return _branch;
        }

        public branches Branch { get { return _branch; } }

    }
}
