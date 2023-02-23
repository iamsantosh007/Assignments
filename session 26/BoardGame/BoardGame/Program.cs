using BoardGame.Models;

namespace BoardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("santosh", InputsForPlay.X);
            Player p2 = new Player("Patro", InputsForPlay.O);
            string[,] board = new string[3, 3];
            bool player1 = true;
            bool player2 = false;
            StartGame(player1,player2,board,p1,p2);
        }
        private static void StartGame(bool player1,bool player2, string[,] board,Player p1,Player p2)
        {
            while (player1 || player2)
            {
                int remainingFields = ShowBoard(board);
                if (remainingFields == board.Length)
                {
                    Console.WriteLine("\t\t\t-----***No fields Remaining to play***---------");
                    PlayAgain(player1,player2,board,p1,p2);
                    return;
                }
                //Player curruntPlayer= null;
                if (player1)
                {
                    FillTheBoxes(p1, board, ref player1, ref player2,p2);
                    continue;

                }

                FillTheBoxes(p2, board, ref player1, ref player2,p2);


            }
        }

        private static int ShowBoard(string[,] board)
        {
            int count = 0;
           
            for (int i = 0; i < 3; i++)
            {
                count+=ContentInsideEachRow(i, board);
                Console.WriteLine();
            }
            return count;
        }

        private static int ContentInsideEachRow(int indexOfRow, string[,] board)
        {
            string[,] boardx = board;
            int elementCount = 0;
            for (int j = 0; j < 3; j++)
            {
                if (board[indexOfRow, j] == null)
                {
                    Console.Write(" " + " | ");
                    continue;
                }

                Console.Write(board[indexOfRow, j] + " | ");
                elementCount++;

            }
            return elementCount;
        }


        private static void FillTheBoxes(Player player, string[,] board, ref bool player1BoolValue, ref bool player2BoolValue,Player player2)
        {
            bool isGreater = false;
            Console.WriteLine("\t\t\t\t-----**"+player.Name + " your turn**---------");
            Console.Write("Enter your value by providing the row and column number:-");
            string input = Console.ReadLine();
            string[] num = input.Split(" ");
            int row = Convert.ToInt32(num[0]);
            int column = Convert.ToInt32(num[1]);
            while(row > 2 || column > 2)
            {
                Console.WriteLine("\n\n-------please provide correct position-----------");
                Console.Write("Enter your value by providing the row and column number:-");
                input = Console.ReadLine();
                num = input.Split(" ");
                row = Convert.ToInt32(num[0]);
                column = Convert.ToInt32(num[1]);
            }
            while (board[row, column] != null)
            {
                //if (row>2 && column>2) Console.WriteLine("please provide correct position");
                Console.WriteLine("\t\t\t-----This place is Already filled---------");
                Console.Write("Enter your value by providing the row and column number:-");
                input = Console.ReadLine();
                num = input.Split(" ");
                row = Convert.ToInt32(num[0]);
                column = Convert.ToInt32(num[1]);
            }
            board[row, column] = player.InputType();
            if (Wingame(player, board,ref player1BoolValue,ref player2BoolValue,player2))
            {

                player1BoolValue = false;
                player2BoolValue = false;
                Console.WriteLine("\t\t\t---Game Over---");
                PlayAgain(player1BoolValue, player2BoolValue, board, player, player2);
                return;
            }
            player1BoolValue = player1BoolValue == true ? false : true;
            player2BoolValue = player2BoolValue == true ? false : true;

        }

        private static void PlayAgain(bool player1, bool player2, string[,] board, Player p1, Player p2)
        {
            Console.WriteLine("-----------------Press y for play and press n to exit--------------");
            char option=Convert.ToChar(Console.ReadLine().ToLower());
            switch (option)
            {
                case 'y':
                    player1= true;
                    player2= false;
                    board = new string[3, 3];
                    StartGame(player1, player2, board, p1, p2);
                    break;
                case 'n':
                    Console.WriteLine("\t\t\t\t---Good bye---");
                    break;
                    
            }
        }

        private static bool Wingame(Player player, string[,] board,ref bool player1BoolValue,ref bool player2BoolValue,Player player2)
        {
            string playerInputType = player.InputType();
            if ((playerInputType == board[0, 0] && playerInputType == board[0, 1] && playerInputType == board[0, 2]) ||
                (playerInputType == board[0, 2] && playerInputType == board[1, 2] && playerInputType == board[2, 2]) ||
                (playerInputType == board[0, 0] && playerInputType == board[1, 0] && playerInputType == board[2, 0]) ||
                (playerInputType == board[1, 0] && playerInputType == board[1, 1] && playerInputType == board[1, 2]) ||
                (playerInputType == board[2, 0] && playerInputType == board[2, 1] && playerInputType == board[2, 2]) ||
                (playerInputType == board[0, 1] && playerInputType == board[1, 1] && playerInputType == board[2, 1]) ||
                (playerInputType == board[0, 0] && playerInputType == board[1, 1] && playerInputType == board[2, 2]) ||
                (playerInputType == board[0, 2] && playerInputType == board[1, 1] && playerInputType == board[2, 0]))
            {
                ShowBoard(board);
                Console.WriteLine($"\t\t----**Bingo {player.Name} You win the gane**----");
                
                return true;
            }
            return false;
        }
    }
}
