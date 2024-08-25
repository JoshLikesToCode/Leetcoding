public class Solution {
    public string SortVowels(string s) {
        var chars = s.ToCharArray();
        var vowels = new List<char>();

        foreach (char c in chars) {
            if (IsVowel(c)) {
                vowels.Add(c);
            }
        }

        vowels.Sort();

        var vowelIndex = 0;
        for (int i = 0; i < chars.Length; i++) {
            if (IsVowel(chars[i])) {
                chars[i] = vowels[vowelIndex++];
            }
        }

        return new string(chars);
    }

     private bool IsVowel(char c) {
        var lowerC = char.ToLower(c);
        return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
    }

}