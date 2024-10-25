public class Solution {
    public IList<string> CellsInRange(string s) {
        var res = new List<string>();
        for(char c = s[0]; c <= s[3]; c++)
            for(char r = s[1]; r <= s[4]; r++)
                res.Add($"{c}{r}");
        return res;
    }
}