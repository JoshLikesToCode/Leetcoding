public class Solution {
    public int NumOfSubarrays(int[] arr) {
        int res = 0, sum = 0, oddCount = 0, evenCount = 1;
        var MOD = 1_000_000_007;
        foreach(var n in arr)
        {
            sum += n;
            if(sum % 2 == 0)
            {
                res += oddCount;
                evenCount++;
            }
            else
            {
                res += evenCount;
                oddCount++;
            }
            res %= MOD;
        }
        return res;
    }
}