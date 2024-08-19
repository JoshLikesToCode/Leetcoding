public class Solution {
    public int MinSteps(int n) {
        var dp = new int[n+1];
        Array.Fill(dp, 1000);
        dp[1] = 0;
        for(var i = 2; i <= n; i++){
            for(var j = 1; j <= (i/2); j++){
                if(i % j == 0 )
                    dp[i] = Math.Min(dp[i], dp[j] + i/j);
            }
        }
        return dp[n];
    }
}