using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PigDiceGame.Models;

namespace PigDiceGame
{
    class Program
    {
        const int winMark = 20;
        

        public static void Main(string[] args)
        {
           
            GameInitialize();  
            
            
            Console.ReadLine();

        }
        public static void GameInitialize()    //initializing the game and in this you will get the looping condition that will take care of your Turn 
        {
            Game game = new Game();
            int initialScore = 0;
            bool start = true;
            Console.WriteLine("welcome to the game of PigDiceGame\n" +
                "Developed by santosh");
            while (start)
            {
                Console.WriteLine();
                Console.WriteLine($"Turn {game.turn}");
                start = StartGame(ref initialScore,game);
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to play again:- y/n");
            char playAgain = Convert.ToChar(Console.ReadLine());
            switch (playAgain)
            {
                case 'y':
                    GameInitialize();
                    break;
                case 'n':
                    Console.WriteLine("thanks for playing");
                    break;
            }
        }
        public static bool StartGame(ref int initialScore,Game game)  //start the game method and in this you will get the play option like roll and hold
        {
            try {
                Console.WriteLine("enter r/h:- ");
                char c = Convert.ToChar(Console.ReadLine());

                int diceNumber = game.GenerateDiceNumber();
                switch (c)
                {
                    case 'r':
                        if (diceNumber == 1 && game.score > 0)
                        {
                            game.score -= initialScore;
                            game.turn++;
                            string comment = initialScore <= 0 ? "You are unlucky because you got 0 in your 1st attempt" : $"currunt Turn score is {initialScore} but you are greedy so your score won't be count";
                            Console.WriteLine(comment);
                            initialScore = 0;
                            return true;
                        }
                        if (diceNumber == 1 && game.score == 0)
                        {
                            game.score = 0;
                            game.turn++;
                            string comment = initialScore <= 0 ? "You are unlucky because you got 0 in your 1st attempt" : $"currunt Turn score is {initialScore} but you are greedy so your score won't be count";
                            Console.WriteLine(comment);
                            initialScore = 0;
                            return true;
                        }
                        if (diceNumber > 1)
                        {
                            initialScore += diceNumber;
                            game.score += diceNumber;
                            bool check = ResultCheck(game.score,game);
                            return check;
                        }
                        break;
                    case 'h':
                        game.turn++;
                        Console.WriteLine($"your turn score is {initialScore}\n" +
                            $"Total score is {game.score}");
                        initialScore = 0;
                        return true;
                    default:
                        Console.WriteLine("please enter in correct format");
                        return true;



                }
                return false;


            }catch(Exception)
            {

                Console.WriteLine("please enter correct option");
                return true;
            }
        }

        public static bool ResultCheck(int score,Game game)
        {
            if (score >= winMark)
            {
                Console.WriteLine($"you win in {game.turn} Turn and your final score is {game.score}");
                return !true;
            }
            return !false;
        }
    }

}
