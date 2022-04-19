namespace ConsoleChessType2;

public class Game
{
    public Board Board = new Board();
    
    private Color _currentPlayer;
    private bool _isCheckMate;
    private bool _isStaleMate;

    public Game()
    {
        _isCheckMate = false;
        _isStaleMate = false; 
        _currentPlayer = Color.Black;
    }

    public void RunGame()
    {
        while (_isCheckMate == false || _isStaleMate == false) // while king is not chess mate or stale mate 
        {
            int x, y , newX, newY;

            Console.WriteLine($"Turn: {SwitchTurn()}");
            PrintBoard(Board.Sqares);
            
            input:
            try
            {
                x = Convert.ToInt16(Console.ReadLine()?.Trim());
                y = Convert.ToInt16(Console.ReadLine()?.Trim());
            
                newX = Convert.ToInt16(Console.ReadLine()?.Trim());
                newY = Convert.ToInt16(Console.ReadLine()?.Trim());

                if (!(x > 0 && x < 8))
                {
                    Console.WriteLine($"{x} is an invalid input");
                    goto input;
                }
                if (!(y > 0 && y < 8))
                {
                    Console.WriteLine($"{y} is an invalid input");
                    goto input;
                }
                if (!(newX > 0 && newX < 8))
                {
                    Console.WriteLine($"{newX} is an invalid input");
                    goto input;
                }
                if (!(newY > 0 && newY < 8))
                {
                    Console.WriteLine($"{newY} is an invalid input");
                    goto input;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                goto input;
            }

            Console.WriteLine($"<----------->");


            if (Board.ValidateColorBeforeMove(x, y, _currentPlayer))
            {
                Board.MoveTo(x,y,newX,newY);
            }
            Console.Clear();
        }
    }

    private void PrintBoard(Peice?[,] array)
    {
        int i = 1;
        foreach (var fields in array)
        {
            // negative number is = right, positive = left 
            var formatedFeild = $"{fields,-1}";
            
            // why does this not work? 
            if (fields == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("|" + $"0");
            }
            else if(fields.Color == Color.White)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|" + $"{formatedFeild}");
            }
            else if (fields.Color == Color.Black)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("|" + $"{formatedFeild}");
            }
            Console.ResetColor();
            
            if (i % 8 == 0)
            {
               Console.Write("|");
               Console.Write((i-1)/8);
               Console.WriteLine();
            }
            i++;
            Console.ResetColor();
            
        }
        Console.WriteLine(" 0 1 2 3 4 5 6 7 ");
    }
 

    private string SwitchTurn()
    {
        if (Color.Black == _currentPlayer)
        {
            _currentPlayer = Color.White;
            return $"white";
        }
        _currentPlayer = Color.Black;
        return $"black";
    }
}