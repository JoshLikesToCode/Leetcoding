public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int start = 1, end = k;
        double avg = 0d, max = 0d, sum = 0d;
        for(var i = 0; i < k; i++)
            sum += nums[i];
        avg = sum / k;
        max = avg;
        while(end < nums.Length)
        {
            sum += nums[end];
            sum -= nums[start - 1];
            avg = sum / k;
            max = Math.Max(max, avg);
            start++;
            end++;
        }
        return max;
    }
}