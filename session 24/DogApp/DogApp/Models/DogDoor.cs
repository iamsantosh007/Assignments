using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogApp.Models
{
    public class DogDoor
    {
        private bool _open;
        private bool _scratchingDoor;

        public DogDoor() { 
        this._open= false;
        this._scratchingDoor= false;
        }

        public void Open() {
            Console.WriteLine("Door open  "+DateTime.Now);
            _open= true;
        }

        public void Close() {
            Console.WriteLine("Door close "+DateTime.Now);
            _open= false;
        }

        public void StartScratching()
        {
            Console.WriteLine("------------scratch start  " + DateTime.Now+"--------------");
            _scratchingDoor= true;
        }

        public void StopScratching()
        {
            Console.WriteLine("----------scratch stop  " + DateTime.Now+"-----------------");
            _scratchingDoor = false;
        }

        public bool IsScratching()
        {
            
            return _scratchingDoor;
        }

        public void NotScratching()
        {
            _scratchingDoor= false;
        }

        public bool IsOpen()
        {
            return _open;
        }

    }
}
