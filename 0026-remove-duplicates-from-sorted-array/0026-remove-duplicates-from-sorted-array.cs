public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var idx = 1;
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i-1] != nums[i])
            {
                nums[idx] = nums[i];
                idx++;
            }
        }
        return idx;
    }
}