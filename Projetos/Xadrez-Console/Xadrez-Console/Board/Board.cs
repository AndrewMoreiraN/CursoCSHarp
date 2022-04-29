using System;
using System.Collections.Generic;
using System.Text;

namespace Board
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
    }
}