public class Solution {
    public int LongestSquareStreak(int[] nums) {
        var res = 0;
        var hs = new HashSet<int>();
        foreach(var n in nums)
            hs.Add(n);
        foreach(var startingNum in nums)
        {
            var currStreak = 0;
            long curr = startingNum;

            while(hs.Contains((int)curr))
            {
                currStreak++;
                if(curr * curr > 1e5)
                    break;
                curr *= curr;
            }
            res = Math.Max(res, currStreak);
        }
        return res < 2 ? -1 : res;
    }
}