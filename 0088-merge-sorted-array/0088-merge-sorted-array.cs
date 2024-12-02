public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int a = 0, b = 0, idx = 0;
        var sortedList = new List<int>();
        while(a < m && b < n)
        {
            int val1 = nums1[a], val2 = nums2[b];

            if(val1 >= val2)
            {
                sortedList.Add(val2);
                b++;
            }
            else
            {
                sortedList.Add(val1);
                a++;
            }
        }
         if(a < nums1.Length)
            sortedList.AddRange(nums1.ToList().Skip(a).Where(x => x != 0));
        if(b < nums2.Length)
            sortedList.AddRange(nums2.ToList().Skip(b));
        idx = 0;
        foreach(var val in sortedList)
            nums1[idx++] = val;
    }
}