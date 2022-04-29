using System;
using Board;

namespace Xadrez_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Board.Board board = new Board.Board(8, 8);
            Screen.ShowingBoardOnScreen(board);
        }
    }
}