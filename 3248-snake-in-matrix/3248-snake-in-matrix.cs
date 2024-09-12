public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        var matrix = new int[n][];
        for(var i = 0; i < n; i++)
            matrix[i] = new int[n];
        for(var i = 0; i < n; i++)
            for(var j = 0; j < n; j++)
                matrix[i][j] = (i * n) + j;
        int c = 0, r = 0;
        foreach(var cmd in commands)
        {
            if(cmd == "RIGHT")
                c++;
            else if(cmd == "LEFT")
                c--;
            else if(cmd == "UP")
                r--;
            else
                r++;
        }
        return matrix[r][c];
    }
}