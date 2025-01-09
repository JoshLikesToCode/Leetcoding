public class Solution {
    public int PrefixCount(string[] words, string pref) {
        var list = words.Where(x => x.Length >= pref.Length)
                        .Where(x => x.Substring(0, pref.Length) == pref);
        return list.Count();
    }
}