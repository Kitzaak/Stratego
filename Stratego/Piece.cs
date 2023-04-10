namespace Stratego;

public class Piece
{
    PieceType _type;

    public Piece()
    {
        _type = PieceType.Empty;
    }

    public Piece(PieceType type)
    {
        _type = type;
    }
    public string Display(bool isSelected = false)
    {
        string leftFiller = isSelected ? ">" :" ";
        string rightFiller = isSelected ? "<" :" ";

        var display = $"{leftFiller}.{rightFiller}";
        if(_type == PieceType.No_Mans_Land)
            display = "###";
        else if(_type == PieceType.Spy)
            display = $"{leftFiller}S{rightFiller}";
        else if(_type == PieceType.Bomb)
            display = $"{leftFiller}B{rightFiller}";
        else if(_type == PieceType.Flag)
            display = "<F>";
        else if(_type == PieceType.One
                || _type == PieceType.Two
                || _type == PieceType.Three
                || _type == PieceType.Four
                || _type == PieceType.Five
                || _type == PieceType.Six
                || _type == PieceType.Seven
                || _type == PieceType.Eight
                || _type == PieceType.Nine
                || _type == PieceType.Ten)
            display = $"{leftFiller}{(int) _type}{rightFiller}";
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