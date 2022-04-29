using Board;

namespace Xadrez_Console
{
    internal class Screen
    {
        public static void ShowingBoardOnScreen(Board.Board board)
        {
            for (int i = 0; i < board.Line; i++)
            {
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.Pieces[i, j] == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.WriteLine(board.Pieces[i, j] + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}