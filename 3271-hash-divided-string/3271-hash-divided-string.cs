public class Solution {
    public string StringHash(string s, int k) {
        var res = string.Empty;
        int sum = 0, idx = 0;

        for (int i = 0; i < s.Length; i++) 
        {
            idx++;
            sum += s[i] - 'a';
            if(idx == k) 
            {
                idx = 0;
                sum %= 26;
                res += (char)('a' + sum);
                sum = 0;
            }
        }
        return res;
    }
}