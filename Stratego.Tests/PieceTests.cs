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
    public void no_mans_land_piece()
    {
        var piece = new Piece();

        piece.SetType(PieceType.No_Mans_Land);

        Assert.Equal("###", piece.Display());
    }
}