public class Solution {
    public int TakeCharacters(string s, int k) {
        var counter = new int[3];
        foreach(var c in s)
            counter[c - 'a']++;
        for(var i = 0; i < 3; i++)
            if(counter[i] < k)
                return -1;
        var window = new int[3];
        int l = 0, max = 0;
        for(var r = 0; r < s.Length; r++)
        {
            window[s[r] - 'a']++;
            while(
                l <= r &&
                (counter[0] - window[0] < k ||
                counter[1] - window[1] < k ||
                counter[2] - window[2] < k)
                )
                {
                    window[s[l] - 'a']--;
                    l++;
                }
            max = Math.Max(max, r - l + 1);
        }
        return s.Length - max;
    }
}