public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        return LowerBound(nums, upper + 1) - LowerBound(nums, lower);
    }

    private long LowerBound(int[] arr, int val)
    {
        int l = 0, r = arr.Length - 1;
        long res = 0L;
        while(l < r)
            if(arr[l] + arr[r] < val)
                res += (r - l++);
            else
                r--;
        return res;
    }
}