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
        static bool IsMoveValid(int choice)
        {
            switch (choice)
            {
                case 1: return board[0, 0] == '1';
                case 2: return board[0, 1] == '2';
                case 3: return board[0, 2] == '3';
                case 4: return board[1, 0] == '4';
                case 5: return board[1, 1] == '5';
                case 6: return board[1, 2] == '6';
                case 7: return board[2, 0] == '7';
                case 8: return board[2, 1] == '8';
                case 9: return board[2, 2] == '9';
                default: return false;
            }
        }
        static void PlaceMove(int choice, char mark)
        {
            switch (choice)
            {
                case 1: board[0, 0] = mark; break;
                case 2: board[0, 1] = mark; break;
                case 3: board[0, 2] = mark; break;
                case 4: board[1, 0] = mark; break;
                case 5: board[1, 1] = mark; break;
                case 6: board[1, 2] = mark; break;
                case 7: board[2, 0] = mark; break;
                case 8: board[2, 1] = mark; break;
                case 9: board[2, 2] = mark; break;
            }
        }
        static int CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return 1;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return 1;
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return 1;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return 1;

            foreach (char c in board)
            {
                if (c != 'X' && c != 'O')
                    return 0;
            }

            return -1; // It's a draw
        }
    }
}