public class Solution {
    public int BinaryGap(int n) {
        var binStr = Convert.ToString(n, 2);
        if(binStr.IndexOf("1") == binStr.LastIndexOf("1"))
            return 0;
        int start = 0, end = 0;
        var res = 0;
        for(var i = 1; i < binStr.Length; i++)
        {
            var count = 0;
            if(binStr[i-1] != binStr[i])
            {
                start = i - 1;
                end = i;
                count = 1;
                while(end < binStr.Length - 1 && binStr[++start] != binStr[++end])
                    count++;
            }
            res = Math.Max(res, count);
        }
        return res;
    }
}