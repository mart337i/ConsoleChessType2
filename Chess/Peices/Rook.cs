namespace Chess.Peices;

public class Rook : Peice
{
    public bool HasMovedOnce { get; set; }
    
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; set; }

    private string Identifiers = "R";

    public Rook(Color color)
    {
        Color = color;
        HasMovedOnce = false;
    }
    
    public override bool Legalmove(int y, int x, int newx, int newy)
    {
        if (HasMovedOnce)
        {
            return true;
        }

        return false;

    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}