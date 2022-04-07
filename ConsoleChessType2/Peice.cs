namespace ConsoleChessType2;

public class Peice
{
    public const int None = 0;
    public const int King = 1;
    public const int Pawn = 2;
    public const int Knight = 3;
    public const int Bishop = 5;
    public const int Rook = 6;
    public const int Queen = 7;

    public const int White = 8;
    public const int Black = 16;
    
   
    
    public static bool IsSlidingPiece (int piece) {
        return (piece & 4) != 0;
    }
}