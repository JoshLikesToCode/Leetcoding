public class Solution {
    public int GenerateKey(params int[] nums) => 
        new[] {1, 10, 100, 1000}.Sum(x => x * nums.Min(y => y / x % 10));
}