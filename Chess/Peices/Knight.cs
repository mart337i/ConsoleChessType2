namespace Chess.Peices;

public class Knight : Peice
{

    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; set; }

    private string Identifiers = "C";

    public Knight(Color color)
    {
        Color = color;
        
    }
    
    public override bool Legalmove(int x, int y, int newX, int newY)
    {
        Console.WriteLine($"Knight class : from {x}, {y}, too {newX},{newY}");

        if (newX == x+1 && newY == y +2)
        {
            return true;
            
        }else if (newX == x - 1 && newY == y - 2)
        {
            return true;
            
        }else if (newX == x - 2 && newY == y - 1)
        {
            return true;
            
        }else if (newX == x + 2 && newY == y -1 )
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