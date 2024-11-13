public class Solution {
    public string StringHash(string s, int k) {
        if(k == 1)
            return s;
        var substrings = new List<string>(){s.Length == k ? s : null};
        substrings.RemoveAll(x => x == null);
        var res = string.Empty;
        for (int length = 1; length < s.Length; length++)
            for (int start = 0; start <= s.Length - length; start+=2)
            {
                var substring = s.Substring(start, length);
                if(substring.Length % k == 0)
                    substrings.Add(substring);
            }
        foreach(var str in substrings)
            res += GetHashValue(str);
        return res;
    }

    private char GetHashValue(string val)
    {
        int x = 0, sum = 0;
        for(var i = 0; i < val.Length; i++)
        {
            for(var start = 'a'; start <= 'z'; start++)
            {
                if(start == val[i])
                {
                    sum += x;
                    x = 0;
                    break;
                }
                x++;
            }
        }
        var res = 'a';
        var count = 0;
        while(++count <= (sum%26))
            res++;
        return res;
    }
}