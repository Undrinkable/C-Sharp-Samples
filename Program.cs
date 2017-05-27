using System;

namespace TicTacToeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ticTacToeBoard = new int[3][];
            for (int index = 0; index < ticTacToeBoard.Length; index++)
            {
                ticTacToeBoard[index] = new int[3];
            }

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine();

            PrintBoard(ticTacToeBoard);

            bool gameOver = false;
            while (!gameOver)
            {
                // get user input
                Console.WriteLine("What's your move?");
                Console.WriteLine("Give your answer as two numbers separated by a comma.");
                Console.WriteLine("Enter END to stop.");
                string input = Console.ReadLine();

                if (input == "END")
                {
                    gameOver = true;
                }
                else
                {
                    // convert user input into tic tac toe board coordinates
                    string[] coordinates = input.Split(',');
                    int x = Convert.ToInt32(coordinates[0]);
                    int y = Convert.ToInt32(coordinates[1]);

                    // set the chosen square to 1
                    ticTacToeBoard[x][y] = 1;

                    // print out the new state of the board
                    PrintBoard(ticTacToeBoard);
                }
            }
        }

        private static void PrintBoard(int[][] board)
        {
            Console.WriteLine(" ------------- ");
            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[0].Length; y++)
                {
                    Console.Write(" | " + board[x][y]);
                }
                Console.WriteLine(" | ");
            }
            Console.WriteLine(" ------------- ");
        }
    }
}
