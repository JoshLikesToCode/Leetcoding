public class Solution {
    public int MinChanges(string s) {
        var curr = s[0];
        int count = 0, min = 0;
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == curr)
            {
                count++;
                continue;
            }
            if(count % 2 == 0)
                count = 1;
            else
            {
                count = 0;
                min++;
            }
            curr = s[i];
        }
        return min;
    }
}