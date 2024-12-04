public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        var sb = new StringBuilder();
        var count = 0;
        for(var i = 0; i < s.Length; i++)
        {
            if(count < spaces.Length && i == spaces[count])
            {
                sb.Append(' ');
                count++;
            }
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}