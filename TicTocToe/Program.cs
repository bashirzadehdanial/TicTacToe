using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3,3]
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static void Main(string[] args)
        {
            int player = 1;
            int result;

            do
            {
                DisplayBoard();
                PlayerMove(player);
                result = CheckWin();
                player++;
            }
            while (result == 0);

            DisplayBoard();

            if (result == 1)
                Console.WriteLine("Player {0} wins!", (player - 1) % 2 + 1);
            else
                Console.WriteLine("It's a draw!");

            Console.ReadLine();
        }

        static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("       |       |       ");

        }
        static void PlayerMove(int player)
        {
            int choice;
            char mark = (player % 2 == 0) ? 'O' : 'X';

            while (true)
            {
                Console.WriteLine("Player {0}'s turn. Enter your move (1-9): ", (player % 2) + 1);
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && IsMoveValid(choice))
                {
                    PlaceMove(choice, mark);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }
    }
}