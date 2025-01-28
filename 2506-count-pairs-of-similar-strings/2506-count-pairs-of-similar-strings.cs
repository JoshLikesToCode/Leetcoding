public class Solution {
    public int SimilarPairs(string[] words) => words
                                                .GroupBy(w => string.Concat(w.Distinct().OrderBy(c => c)))
                                                .Sum(group => (group.Count() - 1) * group.Count() / 2);
}
