public class Solution {
    public long MinimumSteps(string s) {
        var white = 0;
        long totSwap = 0L;

        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == '0')
            {
                totSwap += i - white;
                white++;
            }
        }
        return totSwap;
    }
}