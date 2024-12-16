public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        var idx = 0;
        while(idx < citations.Length && citations[citations.Length - 1 - idx] > idx)
            idx++;
        return idx;
    }
}