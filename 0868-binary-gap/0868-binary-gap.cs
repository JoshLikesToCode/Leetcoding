public class Solution {
    public int BinaryGap(int n) {
        var binStr = Convert.ToString(n, 2);
        if(binStr.IndexOf("1") == binStr.LastIndexOf("1"))
            return 0;
        int res = 0, count = 1;
        for(var i = 0; i < binStr.Length; i++)
            if(binStr[i] == '1')
            {
                res = Math.Max(res, count);
                count = 1;
            }
            else
                count++;
        return res;
    }
}