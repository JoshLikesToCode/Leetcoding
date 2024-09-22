public class Solution {
    public int FindKthNumber(int n, int k) {
        if(k == 1)
            return 1;
        var res = new List<int>();
        var curr = 1;
        for(var i = 0; i < n; i++)
        {
            res.Add(curr);
            if(curr * 10 <= n)
                curr *= 10;
            else
            {
                while(curr % 10 == 9 || curr >= n)
                    curr /= 10;
                curr += 1;
            }
        }
        return res[k - 1];
    }
}