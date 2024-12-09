public class Solution {
    public int Jump(int[] nums) {
        int max = 0, currJump = 0, jumps = 0;
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            max = Math.Max(max, nums[i] + i);
            if(i == currJump)
            {
                jumps++;
                currJump = max;
            }
        }
        return jumps;
    }
}