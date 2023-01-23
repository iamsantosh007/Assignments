using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    class Program
    {

        public static int GetRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            return randomNumber;

        }

        public static bool Start(int randomNumber, ref int lives, ref int tries)
        {
            Console.WriteLine();
            int userValue;
            Console.WriteLine($"enter your number between 1 to 100   you have {lives} left");
            //int userValue = Convert.ToInt32(Console.ReadLine());
            bool parseSuccess=int.TryParse(Console.ReadLine(), out userValue);
            if (!parseSuccess)
            {
                return false;
            }
            tries++;                                            //incrementing the tries value when game start
            lives--;                                             //decremanting the lives of player       
            if (userValue >= 1 && userValue <100)
            {
                if (userValue < randomNumber)
                {
                    Console.WriteLine("Too Low");
                    return false;
                }
                if (userValue > randomNumber)
                {
                    Console.WriteLine("To high");
                    return false;
                }
                if (userValue == randomNumber)
                {
                    Console.WriteLine($"Congratulation You Win with {tries} Tries");
                    return true;
                }

            }
            Console.WriteLine("please enter in range of 1 to 100");
            lives++;         //restoring the lives and tries of user if he mistakely enter value out of range
            tries--;         
            return false;

        }
        public static bool CheckResult(int randomValue, int uuserValue)
        {
            if (randomValue == uuserValue)
                return true;
            return false;

        }

        public static void PlayGame()
        {
            int tries = 0;
            int lives = 3;
            bool flag = true;
            Console.WriteLine("Welcome to Guess Number Game");
            Console.WriteLine("You Will Be Asked To Guess A Number To Win The Game");
            Console.WriteLine();
            int randomNumber = GetRandomNumber();
            while (flag && tries < 3)
            {
                bool result = Start(randomNumber, ref lives, ref tries);
                if (result == true)
                    flag = false;

            }
            if (tries == 3 && flag == true)
                Console.WriteLine($"You use all yours tries");

            Console.WriteLine();
            Console.WriteLine("want to play again(y/n):- ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'y':
                    PlayGame();
                    break;
                case 'n':
                    Console.WriteLine("game over please come again");
                    break;
            }

        }
        public static void Main(string[] args)
        {
            PlayGame();
            Console.ReadLine();
        }
    }
}
