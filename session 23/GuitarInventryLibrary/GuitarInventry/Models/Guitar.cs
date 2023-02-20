using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GuitarInventry.Models
{
    public class Guitar
    {
        private readonly string _serialNumber;
        private readonly double _price;
        
        private GuitarSpec _guitarspec;
       
        public Guitar(string serialNumber, double price,GuitarSpec guitarSpec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _guitarspec = guitarSpec;
            
        }
        public string SerialNumber { get { return _serialNumber; } }
        public double Price { get { return _price; } }
        
        public GuitarSpec getSpec { get { return this._guitarspec; } }
    }
    



}

