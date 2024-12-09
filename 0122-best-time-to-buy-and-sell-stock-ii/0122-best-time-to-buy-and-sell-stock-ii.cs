public class Solution {
    public int MaxProfit(int[] prices) {
        int a = 0, b = 1, max = 0;
        while(b < prices.Length)
            if(prices[a] < prices[b])
                max += prices[b++] - prices[a++];
            else
            {
                a++;
                b++;
            }
        return max;
    }
}