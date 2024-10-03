public class Solution {
    public int MinSubarray(int[] nums, int p) {
        var sum = 0;
        foreach(var n in nums)
            sum = (sum + n) % p;
        var remainder = sum % p;
        if(remainder == 0)
            return 0;
        
        var dict = new Dictionary<int, int>(){{0,-1}};
        int currSum = 0, minLength = nums.Length;

        for(var i = 0; i < nums.Length; i++)
        {
            currSum = (currSum + nums[i]) % p;
            var target = (currSum - remainder + p) % p;
            if(dict.ContainsKey(target))
                minLength = Math.Min(minLength, i - dict[target]);
            dict[currSum] = i;
        }
        return (minLength == nums.Length) ? -1 : minLength;
    }
}