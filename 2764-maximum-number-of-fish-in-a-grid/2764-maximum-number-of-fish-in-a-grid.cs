public class Solution {
    public int FindMaxFish(int[][] grid) {
        var res = 0;
        for(var i = 0; i< grid.Length; i++)
            for(var j = 0; j < grid[i].Length; j++)
                res = Math.Max(res, DFS(grid, i, j));
        return res;
    }

    private int DFS(int[][] grid, int row, int col){
        if(row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == 0)
            return 0;
        
        var fishes = grid[row][col];
        grid[row][col] = 0;

        return fishes +  DFS(grid, row-1, col) + DFS(grid, row+1, col) + DFS(grid, row, col-1) + DFS(grid, row, col+1); 
    }
}