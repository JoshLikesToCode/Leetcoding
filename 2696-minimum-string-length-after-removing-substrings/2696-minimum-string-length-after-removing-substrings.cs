public class Solution {
    public int MinLength(string s) {
        int i = 0;
        while(i < s.Length - 1)
        {
            string w = "" + s[i] + s[i + 1];
            if(w == "AB" || w == "CD")
            {
                s = s.Remove(i, 2);
                i = 0;
                continue;
            }
            i++;
        }
        return s.Length;
    }
}