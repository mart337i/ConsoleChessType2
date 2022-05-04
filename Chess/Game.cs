using Chess.Peices;

namespace Chess
{
    
    public class Game
    {
        private Grapics boardGrapics;
        private Board Board;
        
        private Color _currentPlayer;
        private bool _isCheckMate;
        private bool _isStaleMate;

        public Game()
        {
            boardGrapics = new Grapics();
            Board = new Board();
            
            _isCheckMate = false;
            _isStaleMate = false; 
            _currentPlayer = Color.White;
            
            RunGame();
        }

        public void RunGame()
        {
            while (_isCheckMate == false || _isStaleMate == false) // while king is not chess mate or stale mate 
            {
                int x  = 0 , y = 0 , newX = 0, newY = 0;
                bool input = true;
                
                boardGrapics.PrintTurn(_currentPlayer);
                boardGrapics.PrintBoard(Board.Sqares);

                while (input)
                {
                    try
                    {
                        Console.Write("y value: ");
                        y = Convert.ToInt16(Console.ReadLine()?.Trim());
                        Console.Write("x value: ");
                        x = Convert.ToInt16(Console.ReadLine()?.Trim());
                        
                        if (!(x > -1 && x < 8))
                        {
                            Console.WriteLine($"{x} is an invalid input");
                        }
                        if (!(y > -1 && y < 8))
                        {
                            Console.WriteLine($"{y} is an invalid input");
                        }
                        
                        if (x > -1 && x < 8 && y > -1 && y < 8)
                        {
                            boardGrapics.PrintBoard(Board.Sqares, Board.CurrentLegalmove(y, x));

                            input = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                bool input2 = true;
                while (input2)
                {
                    try
                    {
                        Console.Write("New y value: ");
                        newY = Convert.ToInt16(Console.ReadLine()?.Trim());
                        
                        Console.Write("New x value: ");
                        newX = Convert.ToInt16(Console.ReadLine()?.Trim());

                            
                        if (!(newY > -1 && newY < 8))
                        {
                            Console.WriteLine($"{newY} is an invalid input");
                            
                        }
                        if (!(newY > -1 && newY < 8))
                        {
                            Console.WriteLine($"{newY} is an invalid input");
                            
                        }

                        if (newY > -1 && newY < 8 && newX > -1 && newX < 8)
                        {
                            input2 = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }   

                Console.WriteLine($"<----------->");


                if (Board.ValidateColorBeforeMove(y,x, _currentPlayer))
                {
                    if (Board.Legalmove(y,x,newY,newX) == true) // rename to LegalMove
                    {
                        Console.WriteLine($"moved {Board.Sqares[y,x]} to {newY},{newX}");
                        Board.MoveTo(y,x,newY,newX);
                        SwitchTurn();
                    }
                    else
                    {
                        Console.WriteLine($"is not a legalmove for {Board.Sqares[y,x]?.ToString()} at {y}, {x} ");
                    }
                    
                    Console.WriteLine($"<----------->");
                }
            }
        }
        

        private void SwitchTurn()
        {
            if (Color.Black == _currentPlayer)
            {
                _currentPlayer = Color.White;
            }
            _currentPlayer = Color.Black;
        }
    }
}


