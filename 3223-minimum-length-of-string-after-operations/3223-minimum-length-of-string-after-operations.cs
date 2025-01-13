public class Solution {
    public int MinimumLength(string s) {
        var freqMap = new int[26];
        var res = 0;

        foreach(char c in s)
            freqMap[c - 97]++;
        foreach(var freq in freqMap)
        {
            if(freq == 0)
                continue;
            if(freq % 2 == 0)
                res += 2;
            else
                res += 1;
        }
        return res;
    }
}