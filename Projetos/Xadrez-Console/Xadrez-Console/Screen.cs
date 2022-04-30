using board;
using System;

namespace chess
{
    internal class Screen
    {
        public static void ShowingBoardOnScreen(Board board)
        {
            int number = board.Column;
            char letras = 'A';
            for (int i = 0; i < board.Line; i++)
            {
                Console.Write(number-- + " ");
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.Pieces[i, j] == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Pieces[i, j] + " ");
                    }
                }
                System.Console.WriteLine();
            }
            for (int i = 0; i < board.Column + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write("  ");
                    continue;
                }
                Console.Write(letras++ + " ");
            }
        }
    }
}