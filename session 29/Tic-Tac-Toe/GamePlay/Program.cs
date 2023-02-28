using System.Security.Cryptography;
using Tic_Tac_Toe.Models;

namespace GamePlay
{
    internal class Program
    {
        static void Main()
        {
            Board board= new Board();
            ResultAnalyzer result= new ResultAnalyzer(board);
             //Player[] players = new Player[2] { p1,};
            Player p1=new Player();
            Player p2=new Player();
            Player[] players =new Player[2] { p1,p2};
            Game game = new Game(board,result,players);
            SetPlayerDetails(players);
            bool startGame = true;
            //ShowDetails();
            while(startGame)
            {
                Player curruntPlayer=game.CurruntPlayer;
                Console.WriteLine($"--------------{curruntPlayer.Name} Your turn {curruntPlayer.Mark}!!---------\n");
                Console.WriteLine("please enter your cell number that you want to mark");
                int cellPosition=Convert.ToInt32(Console.ReadLine()); 
                while(cellPosition<0 && cellPosition > 8)
                {
                    cellPosition = Convert.ToInt32(Console.ReadLine());
                }
                game.Play(cellPosition);
                Console.WriteLine();
                ShowBoard(board);
                if (game.Status == ResultType.Win)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"---------------{curruntPlayer.Name} you win the game----------\n");
                    Console.ReadLine();
                    startGame= false;
                    return;
                }
                if (game.Status == ResultType.Draw)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Game draw !Thanks for playing bcoz no field remaining");
                    Console.ResetColor();
                    return;
                }


            }
        }

        private static void ShowBoard(Board board)
        {
            Cell[] cells=board.Cells;
           for(int i=0;i<cells.Length;i++)
            {
                if(i==2||i==5||i==8)
                {
                    Console.WriteLine(cells[i].MarkType);
                    continue;
                }
                if (cells[i].MarkType!=MarkType.Empty)
                {
                    Console.Write(cells[i].MarkType+"  ");
                    continue;
                }
                Console.Write(cells[i].MarkType+"  ");
            }
        }

        private static void SetPlayerDetails(Player[] players)
        {
            Player p1 = players[0];
            Player p2 = players[1];
            Console.Write("Enter the Playe 1 name:- ");
            string playerNameOne = Console.ReadLine();
            p1.Name = playerNameOne;
            Console.Write("Choose your Mark (either x or 0):- ");

            char mark = Convert.ToChar(Console.ReadLine().ToLower());
            if (mark == 'x' || mark == 'X')
                p1.Mark = MarkType.X;
            else
                p1.Mark = MarkType.O;
            Console.Write("Enter the Player 2 name:- ");
            string playerNameTwo = Console.ReadLine();
            p2.Name = playerNameTwo;
            _ = p1.Mark == MarkType.X ? p2.Mark = MarkType.O : p2.Mark = MarkType.X;
        }

        //private static void PlayAgain()
        //{
        //    Console.WriteLine("Play again press y or n to exit:- ");
        //    char choice=Convert.ToChar(Console.ReadLine().ToLower());
        //    switch(choice)
        //    {
        //        case 'y':
        //            Main();
        //            break;
        //        case 'n':
        //            Console.WriteLine("thanks for playing");
        //            break;


        //    }
        //}
    }
}