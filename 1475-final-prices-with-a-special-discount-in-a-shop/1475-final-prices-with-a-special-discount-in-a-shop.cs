public class Solution {
    public int[] FinalPrices(int[] prices) {
        for(var i = 0; i < prices.Length; i++)
        {
            var nextLargestVal = GetMinimumValueRightOfCurrIdx(prices, prices[i], i);
            if(nextLargestVal >= 1)
                prices[i] = prices[i] - nextLargestVal;
        }
        return prices;
    }

    public int GetMinimumValueRightOfCurrIdx(int[] arr, int currVal, int currIdx)
    {
        if(currIdx == arr.Length - 1)
            return -1;
        for(var i = currIdx + 1; i < arr.Length; i++)
            if(arr[i] <= currVal)
                return arr[i];
        return -1;
    }
}