/*        BRUTE FORCE SOLUTION                      */
// public class Solution {
//     public int MaxCount(int m, int n, int[][] ops) {
//         var matrix = new int[m][];
//         for(var i = 0; i < m; i++)
//             matrix[i] = new int[n];

//         foreach(var op in ops)
//         {
//             for(var i = 0; i < op[0]; i++)
//                 for(var j = 0; j < op[1]; j++)
//                     matrix[i][j]++;
//         }
//         var max = Int32.MinValue;
//         for(var i = 0; i < m; i++)
//             for(var j = 0; j < n; j++)
//                 max = Math.Max(max, matrix[i][j]);
//         var res = 0;
//         for(var i = 0; i < m; i++)
//             for(var j = 0; j < n; j++)
//                 if(matrix[i][j] == max)
//                     res++;
//         return res;
//     }
// }


public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        foreach(var op in ops)
        {
            m = Math.Min(m, op[0]);
            n = Math.Min(n, op[1]);
        }
        return m * n;
    }
}