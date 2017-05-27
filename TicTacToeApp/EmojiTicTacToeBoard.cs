public class EmojiTicTacToeBoard : TicTacToeBoard
{
    public EmojiTicTacToeBoard(string player1Name, string player2Name) : base(player1Name, player2Name)
    {
    }

    protected override string GetPlayerSymbol(int playerNumber) {
        if (playerNumber == 1)
        {
            return "\uD83D\uDCA9";
        }
        else if (playerNumber == 2)
        {
            return "\uFE0F";
        }
        else
        {
            return " ";
        }
    }
}