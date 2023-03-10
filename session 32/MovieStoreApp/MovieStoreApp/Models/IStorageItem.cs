using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Models
{
    public interface IStorageItem
    {
        public int Space { get; set; }
        public void Display();
    }
}
