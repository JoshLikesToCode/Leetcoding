public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var words = sentence.Split(" ").Select(x => x.Trim()).ToArray();
        var word = words.Where(x => x.StartsWith(searchWord)).FirstOrDefault();
        return Array.IndexOf(words, word) != -1 ? Array.IndexOf(words, word) + 1 : -1;
    }
}