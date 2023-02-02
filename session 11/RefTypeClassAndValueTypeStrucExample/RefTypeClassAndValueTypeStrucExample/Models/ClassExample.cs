using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeClassAndValueTypeStrucExample.Models
{
    public class ClassExample
    {
        private string _name;
        private int _id;

        public ClassExample(string name, int id)
        {
            this._name = name;
            this._id = id;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int ID { get { return _id; } set { _id = value; } }
    }
}
