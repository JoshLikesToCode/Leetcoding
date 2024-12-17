public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        var freq = new int[26];
        foreach(var c in s)
            freq[c - 'a']++;
        var sb = new StringBuilder();
        // start from largest char and work down
        var idx = 25;
        while(idx >= 0)
        {
            if(freq[idx] == 0)
            {
                idx--;
                continue;
            }
            var canidateChar = Math.Min(freq[idx], repeatLimit);
            for(var k = 0; k < canidateChar; k++)
                sb.Append((char) ('a' + idx));
            freq[idx] -= canidateChar;
            if(freq[idx] > 0)
            {
                var nextIdx = idx - 1;
                while(nextIdx >= 0 && freq[nextIdx] == 0)
                    nextIdx--;
                if(nextIdx < 0)
                    break;
                sb.Append((char)('a' + nextIdx));
                freq[nextIdx]--;
            }
        }
        return sb.ToString();
    }
}