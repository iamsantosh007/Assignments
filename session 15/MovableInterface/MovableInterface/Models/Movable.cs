using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterface.Models
{
    public abstract class Movable:IMovable
    {
        public string model;
        public string brand;

        public abstract void Move();
    }
}
