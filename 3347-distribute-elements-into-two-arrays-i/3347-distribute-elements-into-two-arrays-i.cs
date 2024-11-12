public class Solution {
    public int[] ResultArray(int[] nums) {
        var l1 = new List<int>();
        var l2 = new List<int>();
        bool s1 = true, s2 = false, s3 = false;
        foreach(var n in nums)
        {
            if(s1 == true)
            {
                l1.Add(n);
                s1 = false;
                s2 = true;
            } else if(s2 == true)
            {
                l2.Add(n);
                s2 = false;
            }
            else
            {
                if(l1[l1.Count - 1] > l2[l2.Count - 1])
                    l1.Add(n);
                else
                    l2.Add(n);
            }
        }
        l1.AddRange(l2);
        return l1.ToArray();
    }
}