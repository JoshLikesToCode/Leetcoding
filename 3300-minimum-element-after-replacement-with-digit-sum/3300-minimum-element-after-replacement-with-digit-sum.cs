public class Solution {
    public int MinElement(int[] nums) {
        for(var idx = 0; idx < nums.Length; idx++)
            nums[idx] = DigitSum(nums[idx].ToString());
        return nums.Min();
    }

    public int DigitSum(string nums)
    {
        return Array.ConvertAll(nums.ToCharArray(), x => (int)Char.GetNumericValue(x)).Sum();           
    }
}