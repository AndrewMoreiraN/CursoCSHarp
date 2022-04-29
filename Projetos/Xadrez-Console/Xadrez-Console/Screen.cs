using board;

namespace chess
{
    internal class Screen
    {
        public static void ShowingBoardOnScreen(Board board)
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
                        System.Console.Write(board.Pieces[i, j] + " ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}