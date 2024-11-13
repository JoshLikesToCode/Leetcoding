public class Solution {
    public string GetEncryptedString(string s, int k) {
        var res = string.Empty;
        for(var i = 0; i < s.Length; i++)
        {
            var swapNum = ((k + i) % s.Length);
            res += s[swapNum];
        }
        return res;
    }
}