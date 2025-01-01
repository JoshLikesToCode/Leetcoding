public class Solution {
    public int MaximumMatchingIndices(int[] nums1, int[] nums2) {
        var res = 0;
        for(var i = 0; i < nums2.Length; i++)
        {
            res = Math.Max(res, GetScore(nums1, nums2));
            nums1 = ShiftArrayRight(nums1);
        }
        return res;
    }

    public int GetScore(int[] array1, int[] array2)
    {
        var matchingIdxs = 0;
        for(var i = 0; i < array1.Length; i++)
            if(array1[i] == array2[i])
                matchingIdxs++;
        return matchingIdxs;
    }

    public int[] ShiftArrayRight(int[] array)
    {
        return array.Skip(array.Length - 1).Concat(array.Take(array.Length - 1)).ToArray();
    }
}