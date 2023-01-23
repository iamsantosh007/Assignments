using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame.Models
{
    class Game
    {
        Random randomNumber=new Random();   
        public int score = 0;
        public int turn = 1;
        public int initialScore = 0;
        public int GenerateDiceNumber()
        {
            return randomNumber.Next(1,7);   
        }

        

    }
}
