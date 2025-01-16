public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int l1 = nums1.Length, l2 = nums2.Length, xor1 = 0, xor2 = 0;
        if(l2 % 2 != 0)
            foreach(var n in nums1)
                xor1 ^= n;
        if(l1 % 2 != 0)
            foreach(var n in nums2)
                xor2 ^= n;
        return xor1 ^ xor2;
    }
}