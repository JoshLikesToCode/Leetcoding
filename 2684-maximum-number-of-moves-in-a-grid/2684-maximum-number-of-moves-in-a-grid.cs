public class Solution {
    public int MaxMoves(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        var cur = new HashSet<int>();
        for(int i=0;i<m;i++) {
            cur.Add(i);
        }
        int col = 0;
        while(cur.Any()) {
            var next = new HashSet<int>();
            foreach(int pos in cur) {
                int row = pos;
                for(int j=-1;j<=1;j++) {
                    if (row+j >= 0 && row+j < m && col+1 < n) {
                        if (grid[row][col] < grid[row+j][col+1]) {
                            next.Add(row+j);
                        }
                    }
                }
            }
            cur = next;
            col++;
        }
        return col-1;
    }
}