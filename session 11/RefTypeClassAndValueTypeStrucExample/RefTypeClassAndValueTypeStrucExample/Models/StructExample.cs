using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeClassAndValueTypeStrucExample.Models
{
    public struct StructExample
    {
        public int _id;
        public string _name;

        public StructExample(int id,string name)
        {
            this._id = id;
            this._name = name;
        }
        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name;} set { _name = value; } }
    }
}
