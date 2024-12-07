public class Solution {
    public int MinimumSize(int[] nums, int maxOperations) {
        int l = 1, r = 0;
        foreach(var n in nums)
            r = Math.Max(r, n);
        while(l < r)
        {
            var m = l + (r - l) / 2;
            if(Check(m, nums, maxOperations))
                r = m;
            else
                l = m + 1;
        }
        return l;
    }
    
    private bool Check(int max, int[] nums, int maxOps)
    {
        int tot = 0;
        foreach(var n in nums)
        {
            var ops = (int) Math.Ceiling(n / (double) max) - 1;
            tot += ops;
            if(tot > maxOps)
                return false;
        }
        return true;
    }
}