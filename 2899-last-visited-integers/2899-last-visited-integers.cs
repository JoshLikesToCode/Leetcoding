public class Solution {
    public IList<int> LastVisitedIntegers(int[] nums) {
        IList<int> seen = new List<int>(), ans = new List<int>();
        var k = 0;
        foreach(var n in nums)
            if(n != -1)
            {
                seen.Insert(0, n);
                k = 0;
            }
            else
            {
                k++;
                if(k <= seen.Count)
                    ans.Add(seen[k - 1]);
                else
                    ans.Add(-1);
            }
        return ans;
    }
}