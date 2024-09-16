public class Solution {
    public int ReturnToBoundaryCount(int[] nums) {
        int sum = 0, res = 0;
        foreach(var n in nums)
        {
            sum += n;
            if(sum == 0)
                res++;
        }
        return res;
    }
}