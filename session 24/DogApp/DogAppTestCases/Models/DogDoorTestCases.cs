using DogApp.Models;
using DogApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAppTestCases.Models
{
    [TestClass]
    public class DogDoorTestCases
    {
        [TestMethod]
        public void If_The_Door_ISOPEN_Then_Close_After_5_Second()
        {
            bool expectedResult = false;
            DogDoor dog=new DogDoor();
            Remote remote = new Remote(dog);
            remote.PressButton(); //opening the door and closing automatically after 5 sec
            Assert.AreEqual(expectedResult,dog.IsOpen());
        }

    }
}
