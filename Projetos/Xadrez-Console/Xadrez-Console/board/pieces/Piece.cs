using enums;
using board;

namespace pieces
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public int QtMovements { get; set; }
        public Board Board { get; set; }

        public Piece()
        {
        }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            QtMovements = 0;
            Board = board;
        }
    }
}