public class NeighborSum {

    private readonly int[][] _grid;

    public NeighborSum(int[][] grid) {
        _grid = grid;
    }
    
    public int AdjacentSum(int value) {
        var res = 0;
        for(var i = 0; i < _grid.Length; i++)
        {
            for(var j = 0; j < _grid[i].Length; j++)
            {
                if(_grid[i][j] == value)
                {
                    if(i != 0)
                        res += _grid[i - 1][j];
                    if(i != _grid[i].Length - 1)
                        res += _grid[i + 1][j];
                    if(j != 0)
                        res += _grid[i][j - 1];
                    if(j != _grid[i].Length - 1)
                        res += _grid[i][j + 1];
                }
            }
        }
        return res;
    }
    
    public int DiagonalSum(int value) {
        var res = 0;
        for(var i = 0; i < _grid.Length; i++)
        {
            for(var j = 0; j < _grid[i].Length; j++)
            {
                if(_grid[i][j] == value)
                {
                    if(i > 0 && j > 0)
                        res += _grid[i - 1][j - 1];
                    if(i > 0 && j < _grid[0].Length - 1 )
                        res += _grid[i - 1][j + 1];
                    if(i < _grid.Length - 1 && j > 0 )
                        res += _grid[i + 1][j - 1];
                    if(i < _grid.Length - 1 && j < _grid[i].Length - 1 ) 
                        res += _grid[i + 1][j + 1];
                }
            }
        }
        return res;
    }
}

/**
 * Your NeighborSum object will be instantiated and called as such:
 * NeighborSum obj = new NeighborSum(grid);
 * int param_1 = obj.AdjacentSum(value);
 * int param_2 = obj.DiagonalSum(value);
 */