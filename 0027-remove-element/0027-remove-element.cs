public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var i = 0;
        for(var j = 0; j < nums.Length; j++)
            if(nums[j] != val)
                nums[i++] = nums[j];
        return i;
    }
}