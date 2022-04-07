namespace ConsoleChessType2;

public class Board
{
    public static int[] Sqares;
    bool[] occupied = new bool[Sqares.Length];
    
    public Board()
    {
        Sqares = new int[64];
        SetTable();
        OccupiedField();

    }

    public int MoveTo(int x, int y, int newX,int newY)
    {
        var oldpos = x * y;
        var newPos = newX * newY;
        if (!(8 * 8 < newPos) && newPos > 0)
        {
            Sqares[oldpos] = Sqares[newPos];
        }

        return 0;
    }

    public void OccupiedField()
    {
        for (int i = 0; i < Sqares.Length; i++)
        {
            if (Sqares[i] == 0)
            {
                occupied[i] = false;
            }
        }
    }

    private void SetTable()
    {
        Sqares[9] = Peice.White | Peice.Pawn;
        Sqares[10] = Peice.White | Peice.Pawn;
        Sqares[11] = Peice.White | Peice.Pawn;
        Sqares[12] = Peice.White | Peice.Pawn;
        Sqares[13] = Peice.White | Peice.Pawn;
        Sqares[14] = Peice.White | Peice.Pawn;
        Sqares[15] = Peice.White | Peice.Pawn;
        Sqares[16] = Peice.White | Peice.Pawn;
        Sqares[17] = Peice.White | Peice.Pawn;

        
        Sqares[56] = Peice.Black | Peice.Pawn;
        Sqares[55] = Peice.Black | Peice.Pawn;
        Sqares[54] = Peice.Black | Peice.Pawn;
        Sqares[53] = Peice.Black | Peice.Pawn;
        Sqares[52] = Peice.Black | Peice.Pawn;
        Sqares[51] = Peice.Black | Peice.Pawn;
        Sqares[50] = Peice.Black | Peice.Pawn;
        Sqares[49] = Peice.Black | Peice.Pawn;
        Sqares[48] = Peice.Black | Peice.Pawn;
    }
    
    
}