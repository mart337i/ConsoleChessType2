namespace Chess;

public class Grapics
{
    public void printTurn(Color currentPlayer)
    {
        Console.WriteLine($"Turn: {currentPlayer}");
    }
    
    public void PrintBoard(Peice?[,] array)
    {
        int i = 1;
        foreach (var fields in array)
        {
            // negative number is = right, positive = left 
            var formatedFeild = $"{fields,-1}";

            if (fields == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("|" + $" ");
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
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(" "+ (i-1)/8 + " ");
                Console.WriteLine();
            }
            i++;
            Console.ResetColor();
                
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" 0 1 2 3 4 5 6 7    ");
        Console.ResetColor();

    }
}