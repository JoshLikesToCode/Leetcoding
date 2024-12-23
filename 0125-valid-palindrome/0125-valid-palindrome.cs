public class Solution {
    public bool IsPalindrome(string s) {
        var builder = new StringBuilder();
        foreach(char c in s)
            if(Char.IsLetter(c) && c != ' ')
                builder.Append(Char.ToLower(c));
        return builder.ToString() == new string(builder.ToString().Reverse().ToArray());
    }
}