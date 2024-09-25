public class Solution {
    public int SumOfSquares(int[] nums) {
        return nums.Where((x, idx) =>  nums.Length % (idx + 1) == 0)
                   .Sum(x => x * x);
    }
}