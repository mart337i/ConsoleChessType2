namespace Chess.Peices;

public class Knight : Peice
{
    public bool HasMovedOnce { get; set; }
    
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; set; }

    private string Identifiers = "C";

    public Knight(Color color)
    {
        Color = color;
        HasMovedOnce = false;
    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}