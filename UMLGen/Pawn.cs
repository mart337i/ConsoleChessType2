namespace UMLGen;

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
                if (HasMovedOnceMove[newX,newY] == HasMovedOnceMove[x,y])
                {
                    Console.WriteLine(HasMovedOnceMove[newX,newY]);
                    Console.WriteLine(HasMovedOnceMove[x,y]);
                    HasMovedOnceBool = true;
                    return true;
                }
            }
            if (HasMovedOnceMove[newX,newY] == HasMovedOnceMove[x,y+1])
            {
                Console.WriteLine(HasMovedOnceMove[newX,newY] == HasMovedOnceMove[x,y+1]);
                Console.WriteLine("2");
                HasMovedOnceBool = true;
                return true;
            }
            return false;


        }
        else
        {
            if (Color == Color.White)
            {
                if (HasNotMovedOnce[newX,newY] == HasNotMovedOnce[x,y])
                {
                    Console.WriteLine(HasNotMovedOnce[newX,newY]);
                    Console.WriteLine(HasNotMovedOnce[x,y]);
                    HasMovedOnceBool = true;
                    return true;
                }
            }
            if (HasNotMovedOnce[newX,newY] == HasNotMovedOnce[x,y+2] )
            {
                Console.WriteLine(HasNotMovedOnce[newX,newY] == HasNotMovedOnce[x,y+2] );
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