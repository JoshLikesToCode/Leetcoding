public class Solution {
    public int NumberOfSpecialSubstrings(string s) {
        int substringCount = 0, start = 0;
        var freqMap = new int[26];
        for(var end = 0; end < s.Length; end++)
        {
            freqMap[s[end] - 'a']++;
            while(freqMap[s[end] - 'a'] > 1)
            {
                freqMap[s[start] - 'a']--;
                start++;
            }
            substringCount += (end - start + 1);
        }
        return substringCount;
    }
}


// Brute Force Implementation
// public class Solution {
//     public int NumberOfSpecialSubstrings(string s) {
//         var list = new List<string>();
//         for (var i = 0; i < s.Length; i++)
//             for (var j = i; j < s.Length; j++)
//             {
//                 var substring = s.Substring(i, j - i + 1);
//                 var distinctCount = substring.Distinct().Count();
//                 if(distinctCount == substring.Length)
//                     list.Add(substring);
//             }
//         return list.Count;
//     }
// }