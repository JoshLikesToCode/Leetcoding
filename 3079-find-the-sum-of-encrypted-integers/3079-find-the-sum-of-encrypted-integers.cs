public class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        var helper = new List<int>();
        foreach(var n in nums)
        {
            var strN = n.ToString();
            var max = Int32.MinValue;
            foreach(var c in strN)
            {
                var val = c - '0';
                max = Math.Max(max, val);
            }
            var maxStr = string.Empty;
            for(var i = 0; i < strN.Length; i++)
                maxStr += "" + max;
            max = Int32.Parse(maxStr);
            helper.Add(max);
        }
        return helper.Sum();
    }
}