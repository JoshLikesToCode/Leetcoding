public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        var res = 0;
        for(var i = 0; i < nums.Length - res; i++)
        {
            int currLength = 1, count = nums[i];
            for(var j = i + 1; j < nums.Length; j++)
                if((count & nums[j]) == 0)
                {
                    count |= nums[j];
                    currLength++;
                }
                else
                    break;
            res = Math.Max(res, currLength);
        }
        return res;
    }
}