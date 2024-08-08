public class Solution {
    public int LargestUniqueNumber(int[] nums) {
        var freqMap = new Dictionary<int, int>();
        foreach(var n in nums)
            if(freqMap.ContainsKey(n))
                freqMap[n]++;
            else
                freqMap[n] = 1;
        var res = -1;
        foreach(var kvp in freqMap)
            if(kvp.Value == 1)
                res = Math.Max(res, kvp.Key);
        return res;
    }
}