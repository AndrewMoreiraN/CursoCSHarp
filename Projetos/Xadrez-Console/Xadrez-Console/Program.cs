using board;
using pieces;
using enums;
using exceptions;
using System;

namespace chess
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);
                Screen.ShowingBoardOnScreen(board);
            }
            catch (OutOfBoardException e)
            {
                Console.WriteLine(e);
            }
            catch (PositionOccupiedException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}