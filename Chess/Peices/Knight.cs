namespace Chess.Peices;

public class Knight : Peice
{

    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public override Color Color { get; }

    private string Identifiers = "C";

    public bool[,] _currentlegalmoves;

    public Knight(Color color)
    {
        Color = color;
        _currentlegalmoves = new bool[8,8];

    }
    
    public override bool Legalmove(int x, int y, int newY, int newX)
    {
        Console.WriteLine($"Knight class : from {x}, {y}, too {newY},{newX}");

        if (newY == x+1 && newX == y +2)
        {
            _currentlegalmoves[y, x] = true;
            return true;
            
        }else if (newY == x - 1 && newX == y - 2)
        {
            _currentlegalmoves[y, x] = true;
            return true;
            
        }else if (newY == x - 2 && newX == y - 1)
        {
            _currentlegalmoves[y, x] = true;
            return true;
            
        }else if (newY == x + 2 && newX == y -1 )
        {
            _currentlegalmoves[y, x] = true;
            return true;
        }
        return false;
    }
    
        
    public override bool[,] NextLegalmove(int x, int y)
    {
        return _currentlegalmoves;
    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}