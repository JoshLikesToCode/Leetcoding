public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        var sum = rolls.Sum();
        var remaining = mean * (n + rolls.Length) - sum;

        if(remaining > 6 * n || remaining < n)
            return new int[0];
        var distMean = remaining / n;
        var mod = remaining % n;

        int[] res = new int[n];
        Array.Fill(res, distMean);
        for(var i = 0; i < mod; i++)
            res[i]++;
        return res;
    }
}