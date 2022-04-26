using Chess.Peices;

namespace Chess;

public class Board
{
    public Peice?[,] Sqares;
    public bool[,] Occupied;

    public Board()
    {
        Sqares = new Peice?[8,8];
        Occupied = new bool[8,8];
        SetTable();
        PeiceMap();

    }

    public void MoveTo(int y, int x, int newY, int newX)
    {
        if (!(8 * 8 < newX*newY) && newX*newY > -1)
        {
            Peice? pullVal = Sqares[y,x];
            Sqares[newY,newX] = pullVal;
            Sqares[y,x] = null;
        }
        //update peice map 
        PeiceMap();
    }

    private void PeiceMap()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Sqares[i,j] == null)
                {
                    Occupied[i, j] = false;
                }
                else
                {
                    Occupied[i, j] = true;
                }
            }
        }
    }
    
    
    public bool ValidateColorBeforeMove(int y, int x, Color currenplayer)
    {
        if (Sqares[y,x] == null)
        {
            return false;
        }
        if (Sqares[y,x]!.Color != currenplayer)
        {
            Console.WriteLine("Not your Peice ");
            return false;
        }
        return true;
    }

    public bool Legalmove(int y, int x, int newY, int newX)
    {
        var currentPeice =  Sqares[y,x];
        if (currentPeice != null)
        {
            if (currentPeice.Legalmove(y,x,newY,newX))
            {
                return true;
            }
            return false;
        }
        return false;
    }

    private void SetTable()
    {
        Sqares[1, 0] = new Pawn(Color.Black);
        Sqares[1, 1] = new Pawn(Color.Black);
        Sqares[1, 2] = new Pawn(Color.Black);
        Sqares[1, 3] = new Pawn(Color.Black);
        Sqares[1, 4] = new Pawn(Color.Black);
        Sqares[1, 5] = new Pawn(Color.Black);
        Sqares[1, 6] = new Pawn(Color.Black);
        Sqares[1, 7] = new Pawn(Color.Black);
        
        Sqares[0, 0] = new Rook(Color.Black);
        Sqares[0, 7] = new Rook(Color.Black);
        Sqares[0, 2] = new Bishup(Color.Black);
        Sqares[0, 5] = new Bishup(Color.Black);
        Sqares[0, 1] = new Knight(Color.Black);
        Sqares[0, 6] = new Knight(Color.Black);
        Sqares[0, 4] = new King(Color.Black);
        Sqares[0, 3] = new Queen(Color.Black);


        Sqares[7, 0] = new Rook(Color.White);
        Sqares[7, 7] = new Rook(Color.White);
        Sqares[7, 2] = new Bishup(Color.White);
        Sqares[7, 5] = new Bishup(Color.White);
        Sqares[7, 1] = new Knight(Color.White);
        Sqares[7, 6] = new Knight(Color.White);
        Sqares[7, 4] = new King(Color.White);
        Sqares[7, 3] = new Queen(Color.White);

        Sqares[6, 0] = new Pawn(Color.White);
        Sqares[6, 1] = new Pawn(Color.White);
        Sqares[6, 2] = new Pawn(Color.White);
        Sqares[6, 3] = new Pawn(Color.White);
        Sqares[6, 4] = new Pawn(Color.White);
        Sqares[6, 5] = new Pawn(Color.White);
        Sqares[6, 6] = new Pawn(Color.White);
        Sqares[6, 7] = new Pawn(Color.White);
    }
}