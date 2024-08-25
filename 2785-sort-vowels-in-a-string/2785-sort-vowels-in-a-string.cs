public class Solution {
    public string SortVowels(string s) {
        var count = new Dictionary<char, int>();
        var sortedVowel = "AEIOUaeiou";

        foreach(var c in sortedVowel)
            count[c] = 0;

        foreach(var c in s)
            if(IsVowel(c))
                count[c]++;

        var res = string.Empty;
        var idx = 0;
        for(var i = 0; i < s.Length; i++)
            if(!IsVowel(s[i]))
                res += s[i];
            else
                {
                    while(count[sortedVowel[idx]] == 0)
                        idx++;
                    res += sortedVowel[idx];
                    count[sortedVowel[idx]]--;
                }
        return res;
    }

    bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'o'|| c == 'u'|| c == 'i' 
            || c == 'A' || c == 'E' || c == 'O'|| c == 'U'|| c == 'I';
    }
}