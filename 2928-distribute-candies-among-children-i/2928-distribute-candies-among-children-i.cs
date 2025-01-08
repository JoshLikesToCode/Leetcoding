public class Solution {
    public int DistributeCandies(int n, int limit) {
        var res = 0;
        for(var i = 0; i <= limit; i++)
            for(var j = 0; j <= limit; j++)
                if(n - i - j <= limit && n - i - j >= 0)
                    res++;
        return res;
    }
}