namespace ConsoleChessType2;

public static class HelperClass
{
     private static int[][] numSquaresToEdge;

     public static int X; 
     public static int y; 
     public static int NewX; 
     public static int NewY;

     static void PrecomputedMoveData()
     {
          for (int squareIndex = 0; squareIndex < 8; squareIndex++)
               {
                    int y = squareIndex / 8;
                    int x = squareIndex - y * 8;

                    int north = 7 - y;
                    int south = y;
                    int west = x;
                    int east = 7 - x;
                    numSquaresToEdge[squareIndex] = new int[8];
                    numSquaresToEdge[squareIndex][0] = north;
                    numSquaresToEdge[squareIndex][1] = south;
                    numSquaresToEdge[squareIndex][2] = west;
                    numSquaresToEdge[squareIndex][3] = east;
                    numSquaresToEdge[squareIndex][4] = System.Math.Min (north, west);
                    numSquaresToEdge[squareIndex][5] = System.Math.Min (south, east);
                    numSquaresToEdge[squareIndex][6] = System.Math.Min (north, east);
                    numSquaresToEdge[squareIndex][7] = System.Math.Min (south, west);
               }
     }
}