namespace Chess.Peices;

public class Pawn : Peice
{
    private bool _hasMovedOnceBool;


    // sealed ref 
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
    public sealed override Color Color { get; set; }

    private string Identifiers = "P";

    public Pawn(Color color)
    {
        Color = color;
        _hasMovedOnceBool = false;
    }

    public override bool Legalmove(int y, int x, int newY, int newX)
    {
        Console.WriteLine($"pawn class : from {x}, {y}, too {newX},{newY}");
        Console.WriteLine($"{newY} == {y}");
        Console.WriteLine($"{newX} == {x-2}");
        if (!_hasMovedOnceBool)
        {
            if (Color == Color.White)
            {
                if (newY == y-2)
                {
                    Console.WriteLine("yes what");
                    _hasMovedOnceBool = true;
                    return true;
                }
            }
            if (newY == y+2)
            {
                _hasMovedOnceBool = true;
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
                    _hasMovedOnceBool = true;
                    return true;
                }
            }
            if (newY == y +1)
            {
                _hasMovedOnceBool = true;
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