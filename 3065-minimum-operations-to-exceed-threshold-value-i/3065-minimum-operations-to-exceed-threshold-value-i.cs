public class Solution {
    public int MinOperations(int[] nums, int k) {
        Array.Sort(nums);
        int ptr = 0, res = 0;
        while(ptr < nums.Length)
        {
            if(nums[ptr++] < k)
                res++;
        }
        return res;
    }
}