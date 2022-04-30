using board;
using System;
using pieces;
using enums;

namespace chess
{
    internal class Screen
    {
        public static void ShowingBoardOnScreen(Board board)
        {
            char letras = 'A';
            for (int i = 0; i < board.Line; i++)
            {
                Console.Write(board.Line - i + " ");
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.Pieces[i, j] == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ShowingPiece(board.Pieces[i, j]);
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

        public static void ShowingPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece + " ");
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece + " ");
                Console.ForegroundColor = aux;
            }
        }
    }
}