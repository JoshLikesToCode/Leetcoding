public class Solution {
    public int MaximumValue(string[] strs) {
        var res = 0;
        foreach(var s in strs)
            res = Math.Max(res, CalculateValue(s));
        return res;
    }

    public int CalculateValue(string s)
    {
        if(int.TryParse(s, out int val))
            return val;
        else
            return s.Length;
    }
}