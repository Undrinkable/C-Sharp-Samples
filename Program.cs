using System;

namespace TicTacToeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeBoard ticTacToeBoard = new TicTacToeBoard();

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine();

            ticTacToeBoard.PrintBoard();

            bool gameOver = false;
            int playerNumber = 1;
            while (!gameOver)
            {
                // get user input
                Console.WriteLine("Player {0}, what's your move?", playerNumber);
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

                    // set the chosen square to the play number
                    ticTacToeBoard._board[x][y] = playerNumber;

                    // print out the new state of the board
                    ticTacToeBoard.PrintBoard();

                    // move to next player
                    playerNumber++;
                    if (playerNumber > 2)
                    {
                        playerNumber = 1;
                    }
                }
            }
        }
    }
}
