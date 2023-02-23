using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogApp.Models
{
    public class HouseWindow
    {

        private bool _open;

        public HouseWindow()
        {
            this._open = false;
        }

        public void Open()
        {
            Console.WriteLine("Window open  " + DateTime.Now);
            _open = true;
        }

        public void Close()
        {
            Console.WriteLine("Window close " + DateTime.Now);
            _open = false;
        }

        public bool IsOpen()
        {
            return _open;
        }
    }
}
