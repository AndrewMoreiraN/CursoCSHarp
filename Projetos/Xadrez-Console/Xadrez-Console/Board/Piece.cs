namespace Board
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

        public Piece(Position position, Color color, Board board, int qtMovements = 0)
        {
            Position = position;
            Color = color;
            QtMovements = qtMovements;
            Board = board;
        }
    }
}