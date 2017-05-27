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

    public string GetCurrentPlayerName()
    {
        return GetPlayerName(_playerNumber);
    }

    private string GetPlayerName(int playerNumber)
    {
        if (playerNumber == 1)
        {
            return _player1Name;
        }
        else
        {
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

    public string FindWinner()
    {
        int winnerPlayerNumber = -1;

        int index = 0;
        while (winnerPlayerNumber == -1 && index < _board.Length)
        {
            winnerPlayerNumber = xWinner(index);
            index++;
        }

        index = 0;
        while (winnerPlayerNumber == -1 && index < _board.Length)
        {
            winnerPlayerNumber = yWinner(index);
            index++;
        }

        if (winnerPlayerNumber == -1)
        {
            winnerPlayerNumber = downDiagonalWinner();
        }

        if (winnerPlayerNumber == -1)
        {
            winnerPlayerNumber = upDiagonalWinner();
        }

        if (winnerPlayerNumber != -1)
        {
            return GetPlayerName(winnerPlayerNumber);
        }
        else
        {
            return null;
        }
    }

    private int upDiagonalWinner()
    {
        if (_board[0][2] != 0
            && _board[0][2] == _board[1][1]
            && _board[0][2] == _board[2][0])
        {
            return _board[0][2];
        }
        else
        {
            return -1;
        }
    }

    private int downDiagonalWinner()
    {
        if (_board[0][0] != 0
            && _board[0][0] == _board[1][1]
            && _board[0][0] == _board[2][2])
        {
            return _board[0][0];
        }
        else
        {
            return -1;
        }
    }

    private int xWinner(int index)
    {
        if (_board[index][0] != 0
            && _board[index][0] == _board[index][1]
            && _board[index][0] == _board[index][2])
        {
            return _board[index][0];
        }
        else
        {
            return -1;
        }
    }

    private int yWinner(int index)
    {
        if (_board[0][index] != 0
            && _board[0][index] == _board[1][index]
            && _board[0][index] == _board[2][index])
        {
            return _board[0][index];
        }
        else
        {
            return -1;
        }
    }

    public void PrintBoard()
    {
        Console.WriteLine("  y-0---1---2-- ");
        Console.WriteLine("x ------------- ");
        for (int x = 0; x < _board.Length; x++)
        {
            Console.Write(x);
            for (int y = 0; y < _board[0].Length; y++)
            {
                Console.Write(" | " + GetPlayerSymbol(_board[x][y]));
            }
            Console.WriteLine(" | ");
            Console.WriteLine("| ------------- ");
        }
    }
    protected virtual string GetPlayerSymbol(int playerNumber)
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