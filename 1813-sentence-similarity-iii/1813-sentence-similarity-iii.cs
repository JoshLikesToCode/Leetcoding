public class Solution {
    public bool AreSentencesSimilar(string sentence1, string sentence2) {
        var words1 = sentence1.Split(' ');
        var words2 = sentence2.Split(' ');

        if (words1.Length < words2.Length) {
            var temp = words1;
            words1 = words2;
            words2 = temp;
        }

        int start = 0, end = 0;
        int n1 = words1.Length, n2 = words2.Length;

        while (start < n2 && words1[start] == words2[start]) 
            start++;

        while (end < n2 && words1[n1 - end - 1] == words2[n2 - end - 1]) 
            end++;

        return start + end >= n2;
    }
}