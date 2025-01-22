public class Solution {
    public int SubarraySum(int[] nums) {
        var res = 0;
        for(var i = 0; i < nums.Length; i++)
            for (int start = Math.Max(0, i - nums[i]); start <= i; start++)
                res += nums[start];
        return res;
    }
}