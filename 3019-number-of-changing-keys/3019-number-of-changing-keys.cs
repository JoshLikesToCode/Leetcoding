public class Solution {
    public int CountKeyChanges(string s) {
        s = s.ToLower();
        var res = 0;
        for(var i = 1; i < s.Length; i++)
            if(s[i-1] != s[i])
                res++;
        return res;
    }
}