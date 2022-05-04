namespace Chess;

public class Peice
{
    public virtual Color Color { get; }
    private bool[,] _currentlegalmoves = new bool[8, 8];
    private string Identifiers = " ";

    public Peice()
    {
        Color = Color.None;
    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
    public virtual bool[,] NextLegalmove(int y, int x)
    {
        Console.WriteLine($"no peice on {y},{x}");
        return _currentlegalmoves;
    }
    

    public virtual bool Legalmove(int y, int x, int newY, int newX)
    {
        Console.WriteLine("no overide ");
        return false;
    }
}