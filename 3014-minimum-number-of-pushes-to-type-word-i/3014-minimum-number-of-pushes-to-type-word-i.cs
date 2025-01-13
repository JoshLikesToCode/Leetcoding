public class Solution {
    public int MinimumPushes(string word) => (word.Length - 8 * ((word.Length - 1) / 8)) * (1 + (word.Length - 1) / 8) + 
                8 * (((word.Length - 1) / 8) * (1 + (word.Length - 1) / 8) / 2);  
}