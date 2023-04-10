using System;

namespace Stratego;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Let's play Stratego!");
        var board = new Board();
        Piece[,] pieces = new Piece[,] {
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(PieceType.No_Mans_Land),new Piece(PieceType.No_Mans_Land),new Piece(),new Piece(),new Piece(PieceType.No_Mans_Land),new Piece(PieceType.No_Mans_Land),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(PieceType.No_Mans_Land),new Piece(PieceType.No_Mans_Land),new Piece(),new Piece(),new Piece(PieceType.No_Mans_Land),new Piece(PieceType.No_Mans_Land),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()}
        };

        var selectedRow = 0;
        var selectedCol = 0;
        Console.WriteLine(board.DisplayBoard(pieces, selectedRow, selectedCol));
        ConsoleKeyInfo inputKey;

        var move = false;
        do
        {
            inputKey = Console.ReadKey();
            

            if(inputKey.Key == ConsoleKey.UpArrow)
            {
                if(selectedRow > 0)
                {
                    selectedRow--;
                    move = true;
                }
            }
            else if(inputKey.Key == ConsoleKey.DownArrow)
            {
                if(selectedRow < 9)
                {
                    selectedRow++;
                    move = true;
                }
            }
            else if(inputKey.Key == ConsoleKey.LeftArrow)
            {
                if(selectedCol > 0)
                {
                    selectedCol--;
                    move = true;
                }
            }
            else if(inputKey.Key == ConsoleKey.RightArrow)
            {
                if(selectedCol < 9)
                {
                    selectedCol++;
                    move = true;
                }
            }

            if(move) Console.WriteLine(board.DisplayBoard(pieces, selectedRow, selectedCol));

            Console.WriteLine(inputKey.Key);
            move = false;
        }
        while(inputKey.Key != ConsoleKey.Enter);
    }

    
}
