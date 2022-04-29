using pieces;

namespace board
{
    internal class Board
    {
        public int Line { get; set; }
        public int Column { get; set; }
        public Piece[,] Pieces { get; private set; }

        public Board(int line, int column)
        {
            Line = line;
            Column = column;
            Pieces = new Piece[line, column];
        }

        public void PlacingPiece(Piece p, Position pos)
        {
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
    }
}