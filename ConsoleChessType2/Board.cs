namespace ConsoleChessType2;

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

    public void MoveTo(int x, int y, int newX, int newY)
    {
        if (!(8 * 8 < newX*newY) && newX*newY > -1)
        {
            Peice? pullVal = Sqares[x, y];
            Sqares[newX, newY] = pullVal;
            Sqares[x, y] = null;
            Console.WriteLine($"you moved {pullVal} from {x},{y} to {newX},{newY}");
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
    
    
    public bool ValidateColorBeforeMove(int x, int y, Color currenplayer)
    {
        if (Sqares[x,y] == null)
        {
            return false;
        }
        if (Sqares[x,y]!.Color != currenplayer)
        {
            Console.WriteLine("Not your Peice ");
            return false;
        }
        return true;
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