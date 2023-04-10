using Xunit;

namespace Stratego.Tests;

public class BoardTests
{
    [Fact]
    public void a_new_game_has_empty_board()
    {
        var board = new Board();
        
        Assert.Equal(
        "     1   2   3   4   5   6   7   8   9   10\n" +
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
        "   =========================================\n", board.EmptyBoard());
    }

    [Fact]
    public void send_in_empty_pieces_displays_empty_board()
    {
        var board = new Board();
        
        Piece[,] pieces = new Piece[,] {
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()},
            {new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece(),new Piece()}
        };

        Assert.Equal(
        "     1   2   3   4   5   6   7   8   9   10\n" +
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
        "   =========================================\n", board.DisplayBoard(pieces));
    }

    [Fact]
    public void board_displays_no_mans_land()
    {
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

        Assert.Equal(
        "     1   2   3   4   5   6   7   8   9   10\n" +
        "   =========================================\n" +
        " 1 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 2 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 3 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 4 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 5 | . | . |###|###| . | . |###|###| . | . |\n" +
        " 6 | . | . |###|###| . | . |###|###| . | . |\n" +
        " 7 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 8 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 9 | . | . | . | . | . | . | . | . | . | . |\n" +
        "10 | . | . | . | . | . | . | . | . | . | . |\n" +
        "   =========================================\n", board.DisplayBoard(pieces));
    }

    [Fact]
    public void board_displays_current_cursor_position()
    {
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

        Assert.Equal(
        "     1   2   3   4   5   6   7   8   9   10\n" +
        "   =========================================\n" +
        " 1 |>.<| . | . | . | . | . | . | . | . | . |\n" +
        " 2 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 3 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 4 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 5 | . | . |###|###| . | . |###|###| . | . |\n" +
        " 6 | . | . |###|###| . | . |###|###| . | . |\n" +
        " 7 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 8 | . | . | . | . | . | . | . | . | . | . |\n" +
        " 9 | . | . | . | . | . | . | . | . | . | . |\n" +
        "10 | . | . | . | . | . | . | . | . | . | . |\n" +
        "   =========================================\n", board.DisplayBoard(pieces, 0, 0));
    }
}