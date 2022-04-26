namespace Chess;

public class Peice
{
    public virtual Color Color { get; set; }
    
    
    private string Identifiers = " ";
    
    public override string ToString()
    {
        return $"{Identifiers}";
    }

    public virtual bool Legalmove(int y, int x, int newY, int newX)
    {
        Console.WriteLine("no overide ");
        return false;
    }
}