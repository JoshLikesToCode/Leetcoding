public class Solution {
    public int MaxAscendingSum(int[] nums) {
        var res = 0;
        for(var i = 1; i < nums.Length; i++)
        {
            var sum = nums[i-1];
            while(nums[i-1] < nums[i])
            {
                sum += nums[i];
                if(i < nums.Length - 1)
                    i++;
                else
                    break;
            }
            res = Math.Max(res, sum);
        }
        return res;
    }
}