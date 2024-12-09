public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        var res = new bool[queries.Length];
        var violatingIdxs = new List<int>();
        for(var i = 1; i < nums.Length; i++)
            if(nums[i] % 2 == nums[i - 1] % 2)
                violatingIdxs.Add(i);
        for(var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];
            int start = query[0], end = query[1];
            var found = ModifiedBinSearch(start + 1, end, violatingIdxs);
            res[i] = (found) ? false : true;
        }
        return res;
    }

    private bool ModifiedBinSearch(int start, int end, List<int> violatingIdxs)
    {
        int l = 0, r = violatingIdxs.Count - 1;
        while(l <= r)
        {
            int m = l + (r - l) / 2, violatingIdx = violatingIdxs[m];
            if(violatingIdx < start)
                l = m + 1;
            else if(violatingIdx > end)
                r = m - 1;
            else
                return true;
        }
        return false;
    }
}