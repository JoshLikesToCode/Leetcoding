public class Solution {
    public int NumberOfSpecialChars(string word) {
        int[] lowerFreqMap = new int[26], upperFreqMap = new int[26];
        var res = 0;
        foreach(var c in word)
        {
            if(char.ToLower(c) == c)
                lowerFreqMap[c - 97]++;
            else if(char.ToUpper(c) == c)
                upperFreqMap[char.ToLower(c) - 97]++;
        }
        for(var i = 0; i < 26; i++)
            if(lowerFreqMap[i] >= 1 && upperFreqMap[i] >= 1)
                res++;
        return res;
    }
}