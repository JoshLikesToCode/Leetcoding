public class Solution {
    public bool CheckString(string s) {
        if(!s.Contains('a') || !s.Contains('b'))
            return true;
        var hs = new HashSet<char>();
        foreach(var c in s)
            if(hs.Contains('b') && c == 'a')
                return false;
            else
                hs.Add(c);
        return true;
    }
}