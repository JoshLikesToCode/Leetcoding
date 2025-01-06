public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        var counter = new int[101];
        int pairs = 0, singles = 0;
        for(var i = 0; i < nums.Length; i++)
            counter[nums[i]]++;
        for(var i = 0; i < 101; i++)
        {
            pairs += counter[i] / 2;
            singles += counter[i] % 2;
        }
        return [pairs, singles];
    }
}