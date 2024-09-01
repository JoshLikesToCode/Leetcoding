public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        var res = new int[m][];
        for(var i = 0; i < m; i++)
            res[i] = new int[n];
        var idx = 0;
        for(var i = 0; i < m; i++)
        {
            for(var j = 0; j < n; j++)
            {
                res[i][j] = original[idx++];
            }
        }
        return (idx < original.Length) ? new int[0][] : res;
    }
}