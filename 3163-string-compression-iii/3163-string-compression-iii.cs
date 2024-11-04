public class Solution {
    public string CompressedString(string word) {
        var builder = new StringBuilder();
        var idx = 0;
        while(idx < word.Length)
        {
            var count = 0;
            var curr = word[idx];
            while(
                idx < word.Length &&
                count < 9 &&
                word[idx] == curr
            )
            {
                count++;
                idx++;
            }
            builder.Append(count).Append(curr);
        }
        return builder.ToString();
    }
}