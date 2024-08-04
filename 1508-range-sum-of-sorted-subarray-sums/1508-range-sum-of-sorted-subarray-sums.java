class Solution {
    public int rangeSum(int[] nums, int n, int left, int right) {
        int[] sums = new int[n * (n + 1) / 2];
        int idx = 0;
        for(int i = 0; i < nums.length; i++)
        {
            int sum = 0;
            for(int j = i; j < nums.length; j++)
            {
                sum += nums[j];
                sums[idx++] = sum;
            }
        }
        Arrays.sort(sums);
        
        long res = 0;
        for(int i = left - 1; i <= right - 1; i++)
            res += sums[i];
        
        return (int)(res % ((int)Math.pow(10, 9) + 7));
    }
}