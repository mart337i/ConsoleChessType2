namespace ConsoleChessType2;

public static class PrecomputedMoveData
{
    public static int[][]? _numSquaresToEdge = new int[8][];

    static  PrecomputedMoveData()
    {
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
    }
}