public class Solution {
    public IList<string> StringMatching(string[] words) {
        var res = new HashSet<string>();
        for(var i = 0; i < words.Length; i++)
            for(var j = 0; j < words.Length; j++)
            {
                if(words[i].Contains(words[j]) && words[i] != words[j])
                    res.Add(words[j]);
                else if(words[j].Contains(words[i]) && words[i] != words[j])
                    res.Add(words[i]);
            }
        return new List<string>(res);
    }
}