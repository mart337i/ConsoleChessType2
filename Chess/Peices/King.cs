namespace Chess.Peices;

public class King : Peice
{
    public bool IsInCheck;
    
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public override Color Color { get; }

    private string Identifiers = "K";

    public King(Color color)
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