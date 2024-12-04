public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        int str2Idx = 0, str1Length = str1.Length, str2Length = str2.Length;
        for(var str1Idx = 0; str1Idx < str1Length && str2Idx < str2Length; str1Idx++)
        {
            if (
                str1[str1Idx] == str2[str2Idx] ||
                (str1[str1Idx] + 1 == str2[str2Idx]) ||
                (str1[str1Idx] - 25 == str2[str2Idx])
            )
                str2Idx++;
        }
        return str2Idx == str2Length;
    }
}