public class Solution {
    public long FindTheArrayConcVal(int[] nums) {
        long res = 0L;
        int a = 0, b = nums.Length - 1;
        while(a <= b)
        {
            if(a == b)
                break;
            int leftVal = nums[a], rightVal = nums[b];
            var strVal = new string(leftVal.ToString() + rightVal.ToString());
            res += long.Parse(strVal);
            a++;
            b--;
        }
        if(a == b)
            res += nums[nums.Length / 2];
        return res;
    }
}