public class Solution {
    public bool RotateString(string s, string goal) {
        if(s.Length != goal.Length)
            return false;
        var d = s + s;
        return d.Contains(goal);
    }
}