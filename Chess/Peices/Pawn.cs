namespace Chess.Peices;

public class Pawn : Peice
{
    private bool _hasMovedOnceBool;
    
    public override Color Color { get; }

    private string Identifiers = "P";
    public bool[,] _currentlegalmoves;


    public Pawn(Color color)
    {
        Color = color;
        _hasMovedOnceBool = false;
        _currentlegalmoves = new bool[8, 8];
    }
    
    public override bool[,] NextLegalmove(int y, int x)
    {
        if (!_hasMovedOnceBool)
        {
            if (Color.White == Color)
            {
                _currentlegalmoves[y-2, x] = true;
                _currentlegalmoves[y-1, x] = true;
                
            }else if (Color.White != Color)
            {
                _currentlegalmoves[y+2, x] = true;
                _currentlegalmoves[y+1, x] = true;
            }
        }
        if (Color.White == Color)
        {
            _currentlegalmoves[y-1, x] = true;
        }else if (Color.White != Color)
        {
            _currentlegalmoves[y+1, x] = true;
        }

        return _currentlegalmoves;
    }

    public override bool Legalmove(int y, int x, int newY, int newX)
    {
        if (!_hasMovedOnceBool)
        {
            if (Color == Color.White)
            {
                if (newY == y-2)
                {
                    _hasMovedOnceBool = true;
                    return true;
                }
            }
            if (newY == y+2)
            {
                _hasMovedOnceBool = true;
                return true;
            }
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