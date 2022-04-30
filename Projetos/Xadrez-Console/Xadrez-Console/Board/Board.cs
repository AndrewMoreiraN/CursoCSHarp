using pieces;
using enums;
using System.Data.Common;
using exceptions;

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
            FillTheBoard();
        }

        private void FillTheBoard()
        {
            Pieces[0, 0] = new Rook(Color.Black, this);
            Pieces[0, 7] = new Rook(Color.Black, this);

            Pieces[7, 0] = new Rook(Color.White, this);
            Pieces[7, 7] = new Rook(Color.White, this);

            Pieces[0, 1] = new Knight(Color.Black, this);
            Pieces[0, 6] = new Knight(Color.Black, this);

            Pieces[7, 1] = new Knight(Color.White, this);
            Pieces[7, 6] = new Knight(Color.White, this);

            Pieces[0, 2] = new Bishop(Color.Black, this);
            Pieces[0, 5] = new Bishop(Color.Black, this);

            Pieces[7, 2] = new Bishop(Color.White, this);
            Pieces[7, 5] = new Bishop(Color.White, this);

            Pieces[0, 3] = new Queen(Color.Black, this);

            Pieces[0, 4] = new King(Color.Black, this);

            Pieces[7, 3] = new Queen(Color.White, this);

            Pieces[7, 4] = new King(Color.White, this);

            for (int j = 0; j < Column; j++)
            {
                Pieces[1, j] = new Pawn(Color.Black, this);
                Pieces[6, j] = new Pawn(Color.White, this);
            }
        }

        public void PlacingPiece(Piece p, Position pos)
        {
            PositionAlreadyOccupied(pos);

            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public void PositionAlreadyOccupied(Position pos)
        {
            ValidatePosition(pos);
            if (Pieces[pos.Line, pos.Column] != null)
            {
                throw new PositionOccupiedException("Already have a piece in place!");
            }
        }

        public void ValidatePosition(Position pos)
        {
            if (!VerifyPosition(pos))
            {
                throw new OutOfBoardException("Position out of the board!");
            }
        }

        public bool VerifyPosition(Position pos)
        {
            if (pos.Line < 0 || pos.Line >= Line || pos.Column < 0 || pos.Column >= Column)
            {
                return false;
            }
            return true;
        }
    }
}