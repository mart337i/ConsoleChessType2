namespace Chess.Peices;

public class Queen : Peice
{
    public override Color Color { get; }
    private string Identifiers = "Q";

    public Queen(Color color)
    {
        Color = color;
    }
    
    public override bool Legalmove(int x, int y, int newY, int newX)
    {
        return true;

    }

    public override string ToString()
    {
        return $"{Identifiers}";
    }
}