public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        var list = new List<int>();
        for(var i = 0; i < nums.Length; i++)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                list.Add(Math.Abs(nums[i] - nums[j]));
            }
        }
        var arr = list.ToArray();
        Array.Sort(arr);
        return arr[k - 1];
    }
}