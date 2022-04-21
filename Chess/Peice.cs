namespace Chess;

public class Peice
{
    public virtual Color Color { get; set; }
    
    private string Identifiers = " ";
    
    public override string ToString()
    {
        return $"{Identifiers}";
    }

    public virtual bool Legalmove(int x, int y, int newx, int newy)
    {
        Console.WriteLine("no overide ");
        return false;
    }
}