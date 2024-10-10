public class Solution {
    public int MaxWidthRamp(int[] nums) {
        var maxToTheRight = new int[nums.Length];
        maxToTheRight[nums.Length - 1] = nums[nums.Length - 1];
        for(var i = nums.Length - 2; i >= 0; i--)
            maxToTheRight[i] = Math.Max(maxToTheRight[i+1], nums[i]);
        int l = 0, r = 0, max = 0;
        while(r < nums.Length)
        {
            while(l < r && nums[l] > maxToTheRight[r])
                l++;
            max = Math.Max(max, r - l);
            r++;
        }
        return max;
    }
}