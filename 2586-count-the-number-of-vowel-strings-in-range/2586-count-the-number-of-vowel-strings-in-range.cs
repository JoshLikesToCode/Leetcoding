public class Solution {
    private readonly char[] vowels = new char[]{ 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u'};

    public int VowelStrings(string[] words, int left, int right) {
        var res = 0;
        if(words.Length == 0)
            return res;
        for(var i = left; i <= right; i++)
        {
            if(vowels.Contains(words[i][0])
            && vowels.Contains(words[i][words[i].Length - 1]))
                res++;
        }
        return res;
    }
}