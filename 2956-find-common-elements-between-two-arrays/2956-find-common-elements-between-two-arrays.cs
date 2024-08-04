public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        int c1 = 0, c2 = 0;
        foreach(var n in nums1)
            if(nums2.Contains(n))
                c1++;
        foreach(var n in nums2)
            if(nums1.Contains(n))
                c2++;
        return new int[]{c1, c2};
    }
}