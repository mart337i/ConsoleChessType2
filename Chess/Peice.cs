namespace Chess;

public class Peice
{
    public virtual Color Color { get; set; }
    
    private string Identifiers = " ";
    
    public override string ToString()
    {
        return $"{Identifiers}";
    }
}