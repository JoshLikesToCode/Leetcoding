class Solution {
    public int[] productExceptSelf(int[] nums) {
        int[] res = new int[nums.length];
        int non_zero_prod = Arrays.stream(nums).filter(a -> a != 0).reduce(1, (a, b) -> a*b);
        boolean zero_found = false;
        boolean two_zeroes = false;
        for(int n : nums)
        {
            if(zero_found && n == 0)
                two_zeroes = true;
            if(n == 0)
                zero_found = true;
        }
        
        if(two_zeroes)
        {
            return (new int[nums.length]);
        }
        int resPtr = 0;
        if(!zero_found)
        {
            for(int i = 0; i < nums.length; i++)
            {
                if(nums[i] != 0)
                {
                    int num = non_zero_prod / nums[i];
                    res[resPtr++] = num;
                }
                else
                    res[resPtr++] = non_zero_prod;
            }
        }
        else
        {
            for(int i = 0; i < nums.length; i++)
            {
                if(nums[i] != 0)
                    res[resPtr++] = 0;
                else
                    res[resPtr++] = non_zero_prod;
            }
        }
        return res;
    }
}