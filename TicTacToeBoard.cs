using System;
public class TicTacToeBoard
{
    private int[][] _board;
    private int _playerNumber;
    string _player1Name, _player2Name;

    public TicTacToeBoard(string player1Name, string player2Name)
    {
        _player1Name = player1Name;
        _player2Name = player2Name;

        _board = new int[3][];
        for (int index = 0; index < _board.Length; index++)
        {
            _board[index] = new int[3];
        }

        _playerNumber = 1;
    }

    public string GetCurrentPlayerName() {
        if (_playerNumber == 1) {
            return _player1Name;
        } else {
            return _player2Name;
        }
    }

    public void AddPlayerMove(int x, int y)
    {
        _board[x][y] = _playerNumber;

        _playerNumber++;
        if (_playerNumber > 2)
        {
            _playerNumber = 1;
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