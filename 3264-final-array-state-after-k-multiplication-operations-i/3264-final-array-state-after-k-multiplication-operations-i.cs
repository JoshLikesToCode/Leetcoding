public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        while(k > 0)
        {
            var min = nums.Min();
            var val = min * multiplier;
            var idx = Array.IndexOf(nums, min);
            nums[idx] = val;
            k--;
        }
        return nums;
    }
}