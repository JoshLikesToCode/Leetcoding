public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
        var idxs = new int[nums.Count];
        var range = new int[] {0, Int32.MaxValue};

        while(true)
        {
            int currMin = Int32.MaxValue, currMax = Int32.MinValue, minListIdx = 0;
            for(var i = 0; i < nums.Count; i++)
            {
                var curr = nums[i][idxs[i]];
                if(curr < currMin)
                {
                    currMin = curr;
                    minListIdx = i;
                }
                if(curr > currMax)
                    currMax = curr;
            }
            
            if(currMax - currMin < range[1] - range[0])
            {
                range[0] = currMin;
                range[1] = currMax;
            }
            if(++idxs[minListIdx] == nums[minListIdx].Count)
                break;
        }
        return range;
    }
}