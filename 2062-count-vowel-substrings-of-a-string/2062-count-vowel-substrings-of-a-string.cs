public class Solution {
    public int CountVowelSubstrings(string word) {
        int n = word.Length, res = 0;
        for(var i = 0; i < n; i++)
        {
            var e = "";
            var j = i;
            while(j < n && "aeiou".Contains(word[j]))
            {
                e += word[j];
                if(IsValid(e))
                    res++;
                j++;
            }
        }
        return res;
    }
    bool IsValid(string c)
    {
        if(c.Contains('a') 
            && c.Contains('e') 
            && c.Contains('i') 
            && c.Contains('o') 
            && c.Contains('u')) 
                return true;
        return false;
    }
}