public class Solution {
    public int DeleteGreatestValue(int[][] grid) {
        var res = 0;
        foreach(var g in grid)
            Array.Sort(g);
        for(var i = 0; i < grid[0].Length; i++)
        {
            var max = 0;
            for(var j = 0; j < grid.Length; j++)
                max = Math.Max(grid[j][i], max);
            res += max;
        }
        return res;
    }
}