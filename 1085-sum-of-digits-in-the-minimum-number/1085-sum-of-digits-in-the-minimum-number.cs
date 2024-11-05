public class Solution {
    public int SumOfDigits(int[] nums) {
        var min = nums.Min().ToString();
        var sum = 0;
        for(var i = 0; i < min.Length; i++)
            sum += Int32.Parse(min[i] + "");
        return (sum >= 2 && sum % 2 == 0) ? 1 : 0;
    }
}