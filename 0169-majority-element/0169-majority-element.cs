public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var n in nums)
        {
            if(!dict.ContainsKey(n))
                dict[n] = 1;
            else
                dict[n]++;
            if(dict[n] > (nums.Length / 2))
                return n;
        }
        return -1;
    }
}