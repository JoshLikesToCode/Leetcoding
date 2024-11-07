public class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        
        var substrings = new List<string>(){s};
        for (int length = 1; length < s.Length; length++)
            for (int start = 0; start <= s.Length - length; start++)
            {
                var substring = s.Substring(start, length);
                substrings.Add(substring);
            }

        var res = 0;
        foreach(var substring in substrings)
        {
            var map = new int[2];
            foreach(var c in substring)
                if(c == '0')
                    map[0]++;
                else
                    map[1]++;
            if(map[0] <= k || map[1] <= k)
                res++;
        }
        return res;
    }
}