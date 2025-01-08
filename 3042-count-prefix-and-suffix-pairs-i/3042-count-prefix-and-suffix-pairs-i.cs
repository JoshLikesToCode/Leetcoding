public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        var res = 0;
        for(var i = 0; i < words.Length; i++)
        {
            var word1 = words[i];
            for(var j = i + 1; j < words.Length; j++)
            {
                var word2 = words[j];
                res += (IsPrefixAndSuffix(word1, word2) == true) ? 1 : 0;
            }
        }
        return res;
    }

    public bool IsPrefixAndSuffix(string str1, string str2)
    {
        var prefix = str2.StartsWith(str1);
        var suffix = str2.EndsWith(str2);
        return prefix && suffix;
    }
}