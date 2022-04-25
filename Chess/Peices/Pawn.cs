namespace Chess.Peices;

public class Pawn : Peice
{
    public bool HasMovedOnceBool { get; set; }
    
    public int[,] HasMovedOnceMove { get; set; }
    public int[,] HasNotMovedOnce { get; set; }

    
    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; set; }

    private string Identifiers = "P";

    public Pawn(Color color)
    {
        Color = color;
        HasMovedOnceBool = false;

        HasMovedOnceMove = new int[8, 8];
        HasNotMovedOnce = new int[8, 8];
    }

    public override bool Legalmove(int x, int y, int newX, int newY)
    {
        Console.WriteLine($"pawn class : from {x}, {y}, too {newX},{newY}");
        if (HasMovedOnceBool)
        {
            if (Color == Color.White)
            {
                if (newY == y-2)
                {
                    HasMovedOnceBool = true;
                    return true;
                }
            }
            if (newY == y+2)
            {
                HasMovedOnceBool = true;
                return true;
            }
            return false;
        }
        else
        {
            if (Color == Color.White)
            {
                if (newY == y-1)
                {
                    HasMovedOnceBool = true;
                    return true;
                }
            }
            if (newY == y +1  )
            {
                HasMovedOnceBool = true;
                return true;
            }
        }

        return false;

    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}