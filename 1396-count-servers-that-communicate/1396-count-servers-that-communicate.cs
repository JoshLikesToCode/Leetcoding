public class Solution {
    public int CountServers(int[][] grid) {
        var rowCount = new int[grid[0].Length];
        var colCount = new int[grid.Length];

        for(var r = 0; r < grid.Length; r++)
            for(var c = 0; c < grid[r].Length; c++)
                if(grid[r][c] == 1)
                {
                    rowCount[c]++;
                    colCount[r]++;
                }
        var res = 0;
        for(var r = 0; r < grid.Length; r++)
            for(var c = 0; c < grid[r].Length; c++)
                if(grid[r][c] == 1)
                    if(rowCount[c] > 1 || colCount[r] > 1)
                        res++;
        return res;
    }
}