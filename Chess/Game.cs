using Chess.Peices;

namespace Chess
{
    
    public class Game
    {
        public Board Board = new();
        
        private Color _currentPlayer;
        private bool _isCheckMate;
        private bool _isStaleMate;

        public Game()
        {
            _isCheckMate = false;
            _isStaleMate = false; 
            _currentPlayer = Color.Black;

            RunGame();
        }

        public void RunGame()
        {
            while (_isCheckMate == false || _isStaleMate == false) // while king is not chess mate or stale mate 
            {
                int x  = 0 , y = 0 , newX = 0, newY = 0;
                bool input = true;

                Console.WriteLine($"Turn: {SwitchTurn()}");
                PrintBoard(Board.Sqares);

                while (input)
                {
                    try
                    {
                        Console.Write("y value: ");
                        x = Convert.ToInt16(Console.ReadLine()?.Trim());
                        Console.Write("x value: ");
                        y = Convert.ToInt16(Console.ReadLine()?.Trim());
                
                        Console.Write("New y value: ");
                        newX = Convert.ToInt16(Console.ReadLine()?.Trim());
                        
                        Console.Write("New x value: ");
                        newY = Convert.ToInt16(Console.ReadLine()?.Trim());

                        
                        if (!(x > -1 && x < 8))
                        {
                            Console.WriteLine($"{x} is an invalid input");
                            
                        }
                        if (!(y > -1 && y < 8))
                        {
                            Console.WriteLine($"{y} is an invalid input");
                            
                        }
                        if (!(newX > -1 && newX < 8))
                        {
                            Console.WriteLine($"{newX} is an invalid input");
                            
                        }
                        if (!(newY > -1 && newY < 8))
                        {
                            Console.WriteLine($"{newY} is an invalid input");
                            
                        }

                        if (x > -1 && x < 8 && y > -1 && y < 8 && newX > -1 && newX < 8 && newY > -1 && newY < 8)
                        {
                            input = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                Console.WriteLine($"<----------->");


                if (Board.ValidateColorBeforeMove(x, y, _currentPlayer))
                {
                    if (Board.Legalmove(x,y,newX,newY) == true) // rename to LegalMove
                        {
                            Console.WriteLine("i get here");
                            Board.MoveTo(x,y,newX,newY);
                        }
                        else
                        {
                            Console.WriteLine($"Move x: {x} and y {y}, does not equal a legal move");
                        }
                }
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
}


