public class Solution {
    public int FindLHS(int[] nums) {
        var res = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            var curr = 0;
            var anchor = false;
            for(var j = 0; j < nums.Length; j++)
            {
                if(nums[j] == nums[i])
                    curr++;
                else if(nums[j] + 1 == nums[i])
                {
                    curr++;
                    anchor = true;
                }
                if(anchor)
                    res = Math.Max(res, curr);
            }
        }
        return res;
    }
}