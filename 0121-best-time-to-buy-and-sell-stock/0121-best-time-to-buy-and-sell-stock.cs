public class Solution {
    public int MaxProfit(int[] prices) {
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        foreach(int p in prices)
        {
            min = Math.Min(min, p);
            max = Math.Max(max, p - min);
        }
        return max;
    }
}