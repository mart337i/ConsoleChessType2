namespace Chess;

public class Grapics
{
    public void PrintTurn(Color currentPlayer)
    {
        Console.WriteLine($"Turn: {currentPlayer}");
    }
    
    // overloading method is run at compile time 
    // while overideing [seen in Pawn / peice class] is at runtime 
    // meaning overloading is static polymorphism and overiding is dynamic polymorphism 
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
    
    public void PrintBoard(Peice?[,] array, bool[,] posibleMoves)
    {
        int i = 1;

        for (int y = 0; y < array.GetLength(0); y++)
        {
            for (int x = 0; x < array.GetLength(1); x++)
            {
                // negative number is = right, positive = left 
                var formatedFeild = $"{array[y,x],-1}";
                
                if (array[y,x] == null)
                {
                    if (posibleMoves[y,x])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        
                        Console.Write("|" + $"M");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("|" + $" ");
                        
                    }
                }
                else if(array[y,x]!.Color == Color.White)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|" + $"{formatedFeild}");
                }
                else if (array[y,x]!.Color == Color.Black)
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
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" 0 1 2 3 4 5 6 7    " + Environment.NewLine);
             
        Console.ResetColor();
    }
}