public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        var maxOr = 0;
        foreach (var n in nums) 
            maxOr |= n;
        var count = 0;
        var totalSubsets = 1 << nums.Length;  
        
        for (var mask = 1; mask < totalSubsets; mask++) 
        {
            var currentOr = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if ((mask & (1 << i)) != 0) 
                    currentOr |= nums[i];
            }
            if (currentOr == maxOr)
                count++;
        }

        return count;
    }
}