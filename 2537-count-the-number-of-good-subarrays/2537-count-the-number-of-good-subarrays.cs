public class Solution {
    public long CountGood(int[] nums, int k) {
        int a = 0, b = -1;
        var dict = new Dictionary<int, int>();
        var res = 0L;
        for(var left = 0; left < nums.Length; left++)
        {
            while(a < k && b + 1 < nums.Length)
            {
                b++;
                dict.TryGetValue(nums[b], out int curr);
                a += curr;
                dict[nums[b]] = curr + 1;
            }
            if(a >= k)
                res += nums.Length - b;
            dict[nums[left]] = dict[nums[left]] - 1;
            a -= dict[nums[left]];
        }
        return res;
    }
}