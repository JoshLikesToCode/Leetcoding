public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int>();
        foreach(var w in words1)
            if(!dict1.ContainsKey(w))
                dict1[w] = 1;
            else
                dict1[w]++;
        foreach(var w in words2)
            if(!dict2.ContainsKey(w))
                dict2[w] = 1;
            else
                dict2[w]++;
        var res = 0;
        foreach(var kvp in dict1)
            if(kvp.Value == 1 && dict2.ContainsKey(kvp.Key) && dict2[kvp.Key] == 1)
                res++;
        return res;
    }
}