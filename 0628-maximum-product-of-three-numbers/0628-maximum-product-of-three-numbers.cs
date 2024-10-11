public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        var x1 = nums[nums.Length - 3] * nums[nums.Length - 2] * nums[nums.Length - 1];
        var x2 = nums[0] * nums[1] * nums[nums.Length - 1];
        return (x1 >= x2) ? x1 : x2;
    }
}