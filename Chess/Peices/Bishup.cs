namespace Chess.Peices;

public class Bishup : Peice
{
    
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public override Color Color { get; }

    private string Identifiers = "B";

    public Bishup(Color color)
    {
        Color = color;
    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}