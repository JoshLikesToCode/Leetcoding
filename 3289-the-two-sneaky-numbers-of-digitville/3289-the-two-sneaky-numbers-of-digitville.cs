public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var n in nums)
            if(!dict.ContainsKey(n))
                dict[n] = 1;
            else
                dict[n]++;
        var res = new List<int>();
        foreach(var kvp in dict)
            if(kvp.Value == 2)
                res.Add(kvp.Key);
        return res.ToArray();
    }
}