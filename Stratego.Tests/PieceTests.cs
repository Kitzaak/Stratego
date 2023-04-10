using Xunit;

namespace Stratego.Tests;

public class PieceTests
{
    [Fact]
    public void new_piece_is_blank()
    {
        var piece = new Piece();

        Assert.Equal(" . ", piece.Display());
    }

    [Fact]
    public void show_empty_piece_selected()
    {
        var piece = new Piece();

        piece.SetType(PieceType.Empty);

        Assert.Equal(">.<", piece.Display(true));
    }

    [Fact]
    public void no_mans_land_piece()
    {
        var piece = new Piece();

        piece.SetType(PieceType.No_Mans_Land);

        Assert.Equal("###", piece.Display());
    }

    [Fact]
    public void display_bomb()
    {
        var piece = new Piece();

        piece.SetType(PieceType.Bomb);

        Assert.Equal(" B ", piece.Display());
    }

    [Fact]
    public void display_spy()
    {
        var piece = new Piece();

        piece.SetType(PieceType.Spy);

        Assert.Equal(" S ", piece.Display());
    }

    [Fact]
    public void display_flag()
    {
        var piece = new Piece();

        piece.SetType(PieceType.Flag);

        Assert.Equal("<F>", piece.Display());
    }

    [Fact]
    public void display_one()
    {
        var piece = new Piece();

        piece.SetType(PieceType.One);

        Assert.Equal(" 1 ", piece.Display());
    }
}