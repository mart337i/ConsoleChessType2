namespace Chess.Peices;

public class Rook : Peice
{
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; }

    private string Identifiers = "R";

    public Rook(Color color)
    {
        Color = color;
    }

    public override bool Legalmove(int x, int y, int newY, int newX)
    {
        return true;

    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}