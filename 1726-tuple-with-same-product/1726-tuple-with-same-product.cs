public class Solution {
    public int TupleSameProduct(int[] nums) {
        Array.Sort(nums);
        var res = 0;
        for(var i = 0; i < nums.Length; i++)
            for(var j = nums.Length - 1; j >= i + 1; j--)
            {
                var prod = nums[i] * nums[j];
                var hs = new HashSet<int>();
                for(var x = i + 1; x < j; x++)
                    if(prod % nums[x] == 0)
                    {
                        int val = prod / nums[x];
                        if(hs.Contains(val))
                            res += 8;
                        hs.Add(nums[x]);
                    }
            }
        return res;
    }
}