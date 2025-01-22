public class Solution {
    public long GridGame(int[][] grid) {
        long sum1 = grid[0].Sum(), sum2 = 0L, res = Int64.MaxValue;
        for(var i = 0; i < grid[0].Length; i++)
        {
            sum1 -= grid[0][i];
            res = (long)Math.Min(
                    res, Math.Max(sum1, sum2)
                );
            sum2 += grid[1][i];
        }
        return res;
    }
}