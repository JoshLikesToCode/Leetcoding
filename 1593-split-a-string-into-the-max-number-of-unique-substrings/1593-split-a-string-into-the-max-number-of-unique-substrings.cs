public class Solution {
    public int MaxUniqueSplit(string s) {
        return BackTrack(0, new HashSet<string>(), s);
    }

    private int BackTrack(int idx, HashSet<string> hs, string s)
    {
        var res = 0;
        if(idx >= s.Length)
            return res;
        for(var i = idx; i < s.Length; i++)
        {
            var piece = s.Substring(idx, i - idx + 1);
            if(!hs.Contains(piece))
            {
                hs.Add(piece);
                var bt = 1 + BackTrack(i + 1, hs, s);
                res = Math.Max(res, bt);
                hs.Remove(piece);
            }
        }
        return res;
    }
}