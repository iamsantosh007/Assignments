using DogApp.Models;
using DogApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DogApp
{
    internal class Program
    {

        //static System.Timers.Timer timer = new System.Timers.Timer();

        static void Main(string[] args)
        {
           CaseStudyOneTodAndGina();
            Console.WriteLine("\n\n\n");
           CaseStudyTwoKristeinAndBitsie();
            Console.WriteLine("\n\n\n");
            CsseStudyThreeHollyAndBruce();

        }

        private static void CsseStudyThreeHollyAndBruce()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Bruce want to go outsie and start scratching");
            remote.PressButton();
            Console.WriteLine("Bruce want to again go inside and start scratching");
            remote.PressButton();
        }

        private static void CaseStudyTwoKristeinAndBitsie()
        {
            const int PASSWORD = 1234;
            DogDoor door = new DogDoor();
            HouseWindow houseWindow = new HouseWindow();    
            Remote remote = new Remote(door,houseWindow);
            Console.WriteLine("------Kristein Dog want to go outside---------");
            Console.WriteLine("enter your pssword to open the door");
            int enterPassword = Convert.ToInt32(Console.ReadLine());
            if (enterPassword != 0)
            {
                Console.WriteLine("***successfully password enter***");
            }
            if (enterPassword == 0)
            {
                Console.WriteLine("wrongPassword");
                return;
            }
            OperateRemote(enterPassword,PASSWORD,remote,door,houseWindow);
            Console.WriteLine("------Kristein dog Wants To go in--------");
            OperateRemote(enterPassword, PASSWORD, remote, door, houseWindow);

        }

        private static void CaseStudyOneTodAndGina()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("fido want to go outside");
            remote.PressButton(door);
            Console.WriteLine("Fido Wants To go in");
            remote.PressButton(door);
        }

        private static void OperateRemote(int enterPassword,int Password,Remote remote,DogDoor door,HouseWindow houseWindow)
        {
            if (enterPassword == Password)
            {
                remote.PressButton(door,houseWindow);
                return;
            }
        }
    }
}
