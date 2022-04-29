using board;
using pieces;
using enums;

namespace chess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PlacingPiece(new Rook(Color.Preta, board), new Position(0, 0));
            board.PlacingPiece(new Rook(Color.Preta, board), new Position(1, 3));
            board.PlacingPiece(new King(Color.Preta, board), new Position(2, 4));

            Screen.ShowingBoardOnScreen(board);
        }
    }
}