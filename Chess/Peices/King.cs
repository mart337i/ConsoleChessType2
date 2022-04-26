namespace Chess.Peices;

public class King : Peice
{
    public bool IsInCheck;
    
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; set; }

    private string Identifiers = "K";

    public King(Color color)
    {
        Color = color;
        IsInCheck = false;
    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}