using System;

namespace TicTacToeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ticTacToeBoard = new int[3][];
            for(int index = 0; index < ticTacToeBoard.Length; index++) {
                ticTacToeBoard[index] = new int[3];
            }

            Console.WriteLine(" ------------- ");
            for (int x = 0; x < ticTacToeBoard.Length; x++) {
                for (int y = 0; y < ticTacToeBoard[0].Length; y++) {
                    Console.Write(" | " + ticTacToeBoard[x][y]);
                }
                Console.Write(" | ");
            }
            Console.WriteLine(" ------------- ");           
        }
    }
}
