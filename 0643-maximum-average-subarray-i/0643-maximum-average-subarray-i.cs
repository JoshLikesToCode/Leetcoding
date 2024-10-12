public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if(nums.Length == 1)
            return nums[0];
        if(k == 1)
            return nums.Max();
        if(k == nums.Length)
            return (double)((double)nums.Sum() / k);
        int a = 0, b = 1, n = k - 1;
        double res = 0d;
        while(b < nums.Length)
        {
            var val = nums[a];
            a++;
            while(b < nums.Length)
            {
                val += nums[b];
                n--;
                if(n == 0)
                {
                    res = Math.Max(res, (double)val / k);
                    b = a + 1;
                    break;
                }
                b++;
            }
            n = k - 1;
        }
        return res;
    }
}