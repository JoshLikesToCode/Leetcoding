public class Solution {
    public int[] ResultsArray(int[] nums, int k) {
        var res = new int[nums.Length - k + 1];
        for(var i = 0; i <= nums.Length - k; i++)
        {
            var consecutiveAndSorted = true;
            for(var idx = i; idx < i + k - 1; idx++)
                if(nums[idx + 1] != nums[idx] + 1)
                {
                    consecutiveAndSorted = false;
                    break;
                }
            if(consecutiveAndSorted)
                res[i] = nums[i + k - 1];
            else
                res[i] = -1;
        }
        return res;
    }
}