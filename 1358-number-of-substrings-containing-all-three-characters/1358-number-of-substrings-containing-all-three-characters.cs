public class Solution {
    public int NumberOfSubstrings(string s) {
        int len = s.Length;
        // Track last position of a, b, c
        int[] lastPos = { -1, -1, -1 };
        var res = 0;

        for (var pos = 0; pos < len; pos++) 
        {
            // Update last position of current character
            lastPos[s[pos] - 'a'] = pos;

            // Add count of valid substrings ending at current position
            // If any character is missing, min will be -1
            // Else min gives leftmost required character position
            res += 1 + Math.Min(lastPos[0], Math.Min(lastPos[1], lastPos[2]));
        }

        return res;
    }
}

// public class Solution {
//     public int NumberOfSubstrings(string s) {
//         var stringList = AllSubstrings(s).ToList();
//         var res = (s.Contains("a") && s.Contains("b") && s.Contains("c") ? 1 : 0);
//         foreach(var str in stringList)
//         {
//             if(str.Contains("a")
//                 && str.Contains("b")
//                 && str.Contains("c"))
//                 res++;
//         } 
//         return res;
//     }

//     public static IEnumerable<string> AllSubstrings(string value) 
//     {
//         if (value == null) 
//             yield break; // Or throw ArgumentNullException

//         for (int length = 1; length < value.Length; ++length)
//             for (int start = 0; start <= value.Length - length; ++start)
//             yield return value.Substring(start, length);
//     }
// }