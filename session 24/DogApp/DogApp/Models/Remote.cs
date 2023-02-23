using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogApp.Models;
using System.Timers;
using System.Threading;

namespace DogApp.Services
{
    public class Remote
    {
        static System.Timers.Timer timer = new System.Timers.Timer();
        private DogDoor _door;
        private HouseWindow _houseWindow;
        public Remote(DogDoor door)
        {
            _door = door;
        }

        public Remote(DogDoor door,HouseWindow houseWindow)
        {
            _door = door;
            _houseWindow= houseWindow;

        }

        public DogDoor Door { get { return _door; } }
        public HouseWindow HouseWindow { get { return _houseWindow; } }

        public void PressButton(DogDoor door)
        {
            Console.WriteLine("Remote pressing button");
            if (door.IsOpen())
            {
                door.Close();
                return;
            }
            door.Open();

            
            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset= true;
            timer.Start();
           
            //Thread.Sleep(5010);
           
            //if(!timer.Enabled)
            //{
            //    door.Close();
            //}

            while(timer.Enabled)
            {
                Thread.Sleep(10020);
            }
            door.Close();
        }

        public void PressButton(DogDoor door,HouseWindow houseWindow)
        {
            Console.WriteLine("Remote pressing button");
            if (door.IsOpen() && houseWindow.IsOpen())
            {
                door.Close();
                houseWindow.Close();
                return;
            }
            door.Open();
            houseWindow.Open();


            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();

            //Thread.Sleep(5010);

            //if(!timer.Enabled)
            //{
            //    door.Close();
            //}

            while (timer.Enabled)
            {
                Thread.Sleep(10020);
            }
            door.Close();
            houseWindow.Close();
        }
        public void PressButton() //for bruce
        {
            if (Door.IsOpen() && Door.IsScratching())
            {
                Door.Close();
                return;
            }
            Door.StartScratching();
            if(Door.IsScratching() )
            {
                Door.Open();
                Door.StopScratching();

            }


            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();

            //Thread.Sleep(5010);

            //if(!timer.Enabled)
            //{
            //    door.Close();
            //}

            while (timer.Enabled)
            {
                Thread.Sleep(10020);
            }
            Door.Close();
            
        }
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
 

            timer.Stop();
           

            
        }
    }
}
