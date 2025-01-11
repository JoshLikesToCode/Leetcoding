public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        var res = new List<string>();
        var arrayOfdicts1 = words1.Select(x => GetCharacterMap(x)).ToArray();
        var arrayOfdicts2 = words2.Select(x => GetCharacterMap(x)).ToArray();
        for(var i = 0; i < words1.Length; i++)
        {
            var universal = true;
            var w1Dict = arrayOfdicts1[i];
            for(var j = 0; j < words2.Length; j++)
            {
                var w2Dict = arrayOfdicts2[j];
                foreach(var kvp in w2Dict)
                {
                    if(!w1Dict.ContainsKey(kvp.Key))
                    {
                        universal = false;
                        break;
                    }
                    else if(w1Dict[kvp.Key] - kvp.Value < 0)
                    {
                        universal = false;
                        break;
                    }
                }
                if(!universal)
                    break;
            }
            if(universal)
                res.Add(words1[i]);
        }
        return res;
    }

    public Dictionary<char, int> GetCharacterMap(string word)
    {
        var res = new Dictionary<char, int>();
        foreach(var c in word)
            if(res.ContainsKey(c))
                res[c]++;
            else
                res[c] = 1;
        return res;
    }
}