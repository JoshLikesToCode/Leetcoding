public class Solution {
    public int CountGoodStrings(int low, int high, int zero, int one) {
        var dp = new int[high + 1];
        dp[0] = 1;
        var mod = 1_000_000_007;

        for(var end = 1; end <= high; ++end)
        {
            if(end >= zero)
                dp[end] += dp[end - zero];
            if(end >= one)
                dp[end] += dp[end - one];
            dp[end] %= mod;
        }
        var res = 0;
        for(var i = low; i <= high; ++i)
        {
            res += dp[i];
            res %= mod;
        }
        return res;
    }
}