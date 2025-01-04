public class Solution {
    public int CountPalindromicSubsequence(string s) {
        var hs = new HashSet<char>();
        foreach(char c in s.ToCharArray())
            hs.Add(c);
        int res = 0;
        foreach(char c in hs)
        {
            int start = -1;
            int end = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == c)
                {
                    if(start == -1)
                        start = i;
                    end = i;
                }
            }

            var betweenChars = new HashSet<char>();
            for(int i = start + 1; i < end; i++)
                betweenChars.Add(s[i]);
            res += betweenChars.Count;
        }
        return res;
    }
}