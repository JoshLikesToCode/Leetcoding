public class Solution {
    public int MaximumValue(string[] strs) {
        var list = new List<int>();
        foreach(var s in strs)
            list.Add(CalculateValue(s));
        return list.Max();
    }

    public int CalculateValue(string s)
    {
        if(int.TryParse(s, out int val))
            return val;
        else
            return s.Length;
    }
}