using System;
public class TicTacToeBoard
{
    private int[][] _board;
    private int playerNumber;

    public TicTacToeBoard()
    {
        _board = new int[3][];
        for (int index = 0; index < _board.Length; index++)
        {
            _board[index] = new int[3];
        }

        playerNumber = 1;
    }

    public string GetCurrentPlayerName() {
        return "Player " + playerNumber;
    }

    public void AddPlayerMove(int x, int y)
    {
        _board[x][y] = playerNumber;

        playerNumber++;
        if (playerNumber > 2)
        {
            playerNumber = 1;
        }
    }

    public void PrintBoard()
    {
        Console.WriteLine(" ------------- ");
        for (int x = 0; x < _board.Length; x++)
        {
            for (int y = 0; y < _board[0].Length; y++)
            {
                Console.Write(" | " + GetPlayerSymbol(_board[x][y]));
            }
            Console.WriteLine(" | ");
            Console.WriteLine(" ------------- ");
        }
    }
    private string GetPlayerSymbol(int playerNumber)
    {
        if (playerNumber == 1)
        {
            return "x";
        }
        else if (playerNumber == 2)
        {
            return "o";
        }
        else
        {
            return " ";
        }
    }
}