public class Solution {
    public bool HasSameDigits(string s) {
        var str = string.Empty;
        while(s.Length > 2)
        {
            str="";
            for(int i=1;i<s.Length;i++){
                str += (s[i-1]-'0'+s[i]-'0') % 10;
            }
            s=str;
        }
        return s[0]==s[1];
    }
}