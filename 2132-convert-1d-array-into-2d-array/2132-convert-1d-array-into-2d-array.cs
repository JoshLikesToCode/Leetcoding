public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(m * n != original.Length)
            return new int[0][];
        var res = new int[m][];
        // for(var i = 0; i < m; i++)
        //     res[i] = new int[n];
        var idx = 0;
        for(var i = 0; i < m; i++)
        {
            res[i] = new int[n];
            for(var j = 0; j < n; j++)
            {
                res[i][j] = original[idx++];
            }
        }
        return res;
    }
}