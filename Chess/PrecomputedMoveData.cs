namespace Chess;

public static class PrecomputedMoveData
{
    // First 4 are orthogonal, last 4 are diagonals (N, S, W, E, NW, SE, NE, SW)
    public static readonly int[] DirectionOffsets = { 8, -8, -1, 1, 7, -7, 9, -9 };
    public static int[][]? _numSquaresToEdge = new int[8][];

    static  PrecomputedMoveData()
    {
        // Stores number of moves available in each of the 8 directions for every square on the board
        // Order of directions is: N, S, W, E, NW, SE, NE, SW
        // So for example, if availableSquares[0][1] == 7...
        // that means that there are 7 squares to the north of b1 (the square with index 1 in board array)
        for (int squareIndex = 0; squareIndex < 8; squareIndex++)
        {
            int y = squareIndex / 8;
            int x = squareIndex - y * 8;

            int north = 7 - y;
            int south = y;
            int west = x;
            int east = 7 - x;

            if (_numSquaresToEdge != null)
            {
                _numSquaresToEdge[squareIndex] = new int[8];
                _numSquaresToEdge[squareIndex][0] = north;
                _numSquaresToEdge[squareIndex][1] = south;
                _numSquaresToEdge[squareIndex][2] = west;
                _numSquaresToEdge[squareIndex][3] = east;
                _numSquaresToEdge[squareIndex][4] = Math.Min(north, west);
                _numSquaresToEdge[squareIndex][5] = Math.Min(south, east);
                _numSquaresToEdge[squareIndex][6] = Math.Min(north, east);
                _numSquaresToEdge[squareIndex][7] = Math.Min(south, west);
            }
        }
        
        if (_numSquaresToEdge != null)
            for (int x = 0; x < _numSquaresToEdge.Length; x++)
            {
                for (int y = 0; y < _numSquaresToEdge[x].Length; y++)
                {
                    Console.WriteLine($"next {y}");
                    Console.WriteLine(_numSquaresToEdge[x][y]);
                    Console.WriteLine();
                }
            }
    }
}