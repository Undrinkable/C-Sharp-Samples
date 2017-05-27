using System;

namespace TicTacToeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine();
            Console.WriteLine("Player 1, what's your name?");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Player 2, what's your name?");
            string player2Name = Console.ReadLine();

            TicTacToeBoard ticTacToeBoard = new TicTacToeBoard(player1Name, player2Name);

            ticTacToeBoard.PrintBoard();

            bool gameOver = false;
            while (!gameOver)
            {
                // get user input
                Console.WriteLine("{0}, what's your move?", ticTacToeBoard.GetCurrentPlayerName());
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
                    ticTacToeBoard.AddPlayerMove(x, y);

                    // print out the new state of the board
                    ticTacToeBoard.PrintBoard();
                }
            }
        }
    }
}
