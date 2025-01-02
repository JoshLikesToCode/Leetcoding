public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int[] res = new int[queries.Length], prefixSum = new int[words.Length];
        var vowels = new HashSet<char>(){'a', 'e', 'i', 'o', 'u'};
        var sum = 0;
        for(var i = 0; i < words.Length; i++)
        {
            var curr = words[i];
            if(vowels.Contains(curr[0]) && vowels.Contains(curr[^1]))
                sum++;
            prefixSum[i] = sum;
        }

        for(var i = 0; i < queries.Length; i++)
        {
            var curr = queries[i];
            res[i] = 
                prefixSum[curr[1]] -
                    (curr[0] == 0 ? 0 : prefixSum[curr[0] - 1]);
        }
        return res;
    }
}