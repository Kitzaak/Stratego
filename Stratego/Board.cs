namespace Stratego;

public class Board
{
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
}