using System;

namespace TicTacToeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ticTacToeBoard = new int[3][];
            ticTacToeBoard[0] = new int[3];
            ticTacToeBoard[1] = new int[3];
            ticTacToeBoard[2] = new int[3];

            Console.WriteLine(" ------------- ");
            Console.WriteLine(" | " + ticTacToeBoard[0][0] + " | " + ticTacToeBoard[1][0] + " | " + ticTacToeBoard[2][0] + " | ");
            Console.WriteLine(" ------------- ");
            Console.WriteLine(" | " + ticTacToeBoard[0][1] + " | " + ticTacToeBoard[1][1] + " | " + ticTacToeBoard[2][1] + " | ");
            Console.WriteLine(" ------------- ");
            Console.WriteLine(" | " + ticTacToeBoard[0][2] + " | " + ticTacToeBoard[1][2] + " | " + ticTacToeBoard[2][2] + " | ");
            Console.WriteLine(" ------------- ");            
        }
    }
}
