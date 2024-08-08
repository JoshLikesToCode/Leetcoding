public class Solution {
    public bool IsSubstringPresent(string s) {
        var copy = s.ToCharArray();
        Array.Reverse(copy);
        var revStr = new String(copy);
        for(int i = 1; i < s.Length; i++)
        {
            var s1 = s[i-1].ToString() + s[i].ToString();
            for(int j = 1; j < s.Length; j++)
            {
                var s2 = revStr[j-1].ToString() + revStr[j].ToString();
                if(s2 == s1)
                    return true;
            }
        }
        return false;
    }
}