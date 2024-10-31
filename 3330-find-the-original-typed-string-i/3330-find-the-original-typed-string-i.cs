public class Solution {
    public int PossibleStringCount(string word) {
        var res = 1;
        var idx = 0;
        while(idx < word.Length)
        {
            var j = idx;
            while(j < word.Length && word[j] == word[idx])
                j++;
            var length = j - idx;
            res += length - 1;
            idx = j;
        }
        return res;
    }
}