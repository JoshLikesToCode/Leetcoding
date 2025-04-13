public class Solution {
    private long _mod = 1_000_000_007;
    public int CountGoodNumbers(long n) {
        return (int)((Helper(5, (n + 1) / 2) * Helper(4, n / 2)) % _mod);
    }

    private long Helper(int x, long y)
    {
        long res = 1, mult = x;
        while (y > 0) 
        {
            if (y % 2 == 1) 
                res = (res * mult) % _mod;
            mult = (mult * mult) % _mod;
            y /= 2;
        }
        return res;
    }
}