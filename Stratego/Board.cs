namespace Stratego;

public class Board
{
    int _selectedRow;
    int _selectedCol;

    public string EmptyBoard()
    {
        var screen = "     1   2   3   4   5   6   7   8   9   10\n" +
        "   =========================================\n" +
        " 1 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 2 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 3 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 4 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 5 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 6 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 7 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 8 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 9 | . | . | . | . | . | . | . | . | . | . |\n" +
        "10 | . | . | . | . | . | . | . | . | . | . |\n" +
        "   =========================================\n";

        return screen;
    }

    public string DisplayBoard(Piece[,] pieces, int selectedRow, int selectedCol)
    {
        _selectedRow = selectedRow;
        _selectedCol = selectedCol;

        string display = TopNumbers() +
            TopBottom() +
            PieceRow(GetRowOfPieces(pieces, 0), 1) +
            PieceRow(GetRowOfPieces(pieces, 1), 2) +
            PieceRow(GetRowOfPieces(pieces, 2), 3) +
            PieceRow(GetRowOfPieces(pieces, 3), 4) +
            PieceRow(GetRowOfPieces(pieces, 4), 5) +
            PieceRow(GetRowOfPieces(pieces, 5), 6) +
            PieceRow(GetRowOfPieces(pieces, 6), 7) +
            PieceRow(GetRowOfPieces(pieces, 7), 8) +
            PieceRow(GetRowOfPieces(pieces, 8), 9) +
            PieceRow(GetRowOfPieces(pieces, 9), 10) +
            TopBottom();

        return display;
    }

    public string DisplayBoard(Piece[,] pieces)
    {
        return DisplayBoard(pieces, -1, -1);
    }

    Piece[] GetRowOfPieces(Piece[,] pieces, int row)
    {
        Piece[] rowOfPieces = new Piece[10];

        for(int i = 0; i < 10; i++)
        {
            rowOfPieces[i] = pieces[row, i];
        }

        return rowOfPieces;
    }

    string TopNumbers()
    {
        return "     1   2   3   4   5   6   7   8   9   10\n";
    }

    string TopBottom()
    {
        return "   =========================================\n";
    }

    string PieceRow(Piece[] pieces, int row)
    {
        string num;
        if(row == 10)
            num = "10 ";
        else
            num = $" {row} ";

        var rowDisplay = num + "|";
        for(int i = 0; i < pieces.Length; i++)
        {
            if(_selectedRow == row - 1 && _selectedCol == i)
                rowDisplay += pieces[i].Display(true) + "|";
            else
                rowDisplay += pieces[i].Display() + "|";
        }

        return rowDisplay + "\n";
    }
}