//            Brute Force Solution
//  public class Solution {
//     public int SmallestDistancePair(int[] nums, int k) {
//         var list = new List<int>(nums.Length);
//         list.AddRange(nums);
//         for(var i = 0; i < nums.Length; i++)
//         {
//             for(var j = i + 1; j < nums.Length; j++)
//             {
//                 list.Add(Math.Abs(nums[i] - nums[j]));
//             }
//         }
//         list.Sort();
//         return list.ToArray()[k - 1];
//     }
// }

public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        var max = Int32.MinValue;
        foreach(var n in nums)
            max = Math.Max(max, n);
        var bucket = new int[max + 1];
        for(var i = 0; i < nums.Length; i++)
            for(var j = i + 1; j < nums.Length; j++)
            {
                var dist = Math.Abs(nums[i] - nums[j]);
                bucket[dist]++;
            }
        
        // find kth smallest
        for(var i = 0; i <= max; i++)
        {
            k -= bucket[i];
            if(k <= 0)
                return i;
        }
        return -1;
    }
}