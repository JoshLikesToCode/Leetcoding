public class Solution {
    public int MinimumPushes(string word) {
        var freq = new int[26];
        foreach(var c in word)
            freq[c - 97]++;
        Array.Sort(freq);
        var sortedFreq = new int[26];
        for(var i = 0; i < 26; i++)
            sortedFreq[i] = freq[25 - i];
        var res = 0;
        for (int i = 0; i < 26; i++)
            if (sortedFreq[i] == 0) 
                break;
            else
                res += (i / 8 + 1) * sortedFreq[i];
        
        return res;
    }
}