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
    }

    public void RunGame()
    {
        while (_isCheckMate == false || _isStaleMate == false) // while king is not chess mate or stale mate 
        {
            Console.WriteLine(SwitchTurn());

            int x = Convert.ToInt16(Console.ReadLine()?.Trim());
            int y = Convert.ToInt16(Console.ReadLine()?.Trim());
            
            int newX = Convert.ToInt16(Console.ReadLine()?.Trim());
            int newY = Convert.ToInt16(Console.ReadLine()?.Trim());
            
            Console.WriteLine($"<----------->");

            //PrintBoard(x, y, Board.Sqares);

            Board.MoveTo(x,y,newX,newY);

            //for (int i = 0; i < Board.Sqares.Length; i++)
            //{
            //    Console.WriteLine(Board.Sqares[i++]);
            //}
            //
            //Console.WriteLine($"<----------->");


        }
    }

    public void PrintBoard(int x, int y, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(String.Format($"{array[j+i]}\t"));
            }
        }
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