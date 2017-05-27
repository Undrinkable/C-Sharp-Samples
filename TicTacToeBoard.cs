using System;
public class TicTacToeBoard
{
    public int[][] _board;

    public TicTacToeBoard()
    {
        _board = new int[3][];
        for (int index = 0; index < _board.Length; index++)
        {
            _board[index] = new int[3];
        }
    }

    public void PrintBoard()
    {
        Console.WriteLine(" ------------- ");
        for (int x = 0; x < _board.Length; x++)
        {
            for (int y = 0; y < _board[0].Length; y++)
            {
                Console.Write(" | " + _board[x][y]);
            }
            Console.WriteLine(" | ");
        }
        Console.WriteLine(" ------------- ");
    }
}