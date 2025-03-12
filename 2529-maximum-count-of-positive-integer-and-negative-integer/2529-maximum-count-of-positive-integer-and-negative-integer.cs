public class Solution {
    public int MaximumCount(int[] nums) {
        var pos = nums.Where(x => x >= 1).Count();
        var neg = nums.Where(x => x <= -1).Count();
        return (pos >= neg) ? pos : neg;
    }
}