namespace Stratego;

public class Piece
{
    PieceType _type = PieceType.Empty;
    public string Display()
    {
        var display = " . ";
        if(_type == PieceType.No_Mans_Land)
            display = "###";
        return display;
    }

    public void SetType(PieceType type)
    {
        _type = type;
    }
}

public enum PieceType
{
    Empty,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Spy,
    Bomb,
    Flag,
    No_Mans_Land
}