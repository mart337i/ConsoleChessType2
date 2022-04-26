namespace Chess;

public class Peice
{
    public virtual Color Color { get; set; }
    
    
    private string Identifiers = " ";
    
    public override string ToString()
    {
        return $"{Identifiers}";
    }

    public virtual bool Legalmove(int x, int y, int NewY, int NewX)
    {
        Console.WriteLine("no overide ");
        return false;
    }
}