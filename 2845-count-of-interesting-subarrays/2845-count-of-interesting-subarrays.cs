public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        var dict = new Dictionary<int, int>();
        var res = 0L;
        var prefix = 0;
        dict[0] = 1;
        for(var i = 0; i < nums.Count; i++)
        {
            prefix += nums[i] % modulo == k ? 1 : 0;
            res += dict.ContainsKey((prefix - k + modulo) % modulo)
                ? dict[(prefix - k + modulo) % modulo]
                : 0;
            if(dict.ContainsKey(prefix % modulo))
                dict[prefix % modulo]++;
            else
                dict[prefix % modulo] = 1;
        }
        return res;
    }
}