public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        var hs = new HashSet<int>();
        foreach(var n in nums)
            hs.Add(Convert.ToInt32(n, 2));
        for(var n = 0; n <= nums.Length; n++)
            if(!hs.Contains(n))
            {
                var res = Convert.ToString(n, 2);
                while(res.Length < nums.Length)
                    res = "0" + res;
                return res;
            }
        return "";
    }
}