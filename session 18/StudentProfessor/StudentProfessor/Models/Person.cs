using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessor.Models
{
    class Person
    {
        protected int _id;
        protected string _address;
        protected int _dob;

        public Person(int id,string address,int dob)
        {
            this._id= id;
            this._address= address;
            this._dob= dob;
        }

        public int Id { get { return _id; }}
        public string Address { get { return _address; } }
        public int Dob { get { return _dob; } }
    }
}
