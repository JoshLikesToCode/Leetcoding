public class Solution {
    public int MaximumSum(int[] nums) {
        var res = -1;
        for(var i = 0; i < nums.Length; i++)
        {
            var v1 = DigitSum(nums[i]);
            for(var j = i + 1; j < nums.Length; j++)
                if(DigitSum(nums[j]) == v1)
                    res = Math.Max(res, nums[i] + nums[j]);
        }
        return res;
    }

    public int DigitSum(int n)
    {
        var sum = 0;
        foreach(var c in n.ToString())
            sum += c - '0';
        return sum;
    }
}