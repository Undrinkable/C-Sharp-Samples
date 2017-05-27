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
                Console.Write(" | ");
            }
            Console.WriteLine(" ------------- ");
        }
    }
}
