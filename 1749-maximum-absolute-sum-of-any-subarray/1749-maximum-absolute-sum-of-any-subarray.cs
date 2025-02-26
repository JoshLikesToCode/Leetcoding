public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int minPrefixSum = 0, maxPrefixSum = 0, currPrefixSum = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            currPrefixSum += nums[i];
            minPrefixSum = Math.Min(minPrefixSum, currPrefixSum);
            maxPrefixSum = Math.Max(maxPrefixSum, currPrefixSum);
        }
        return maxPrefixSum - minPrefixSum;
    }
}