public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        var matrix = new int[n][];
        for(var i = 0; i < n; i++)
            matrix[i] = new int[n];
        for(var i = 0; i < n; i++)
            for(var j = 0; j < n; j++)
                matrix[i][j] = (i * n) + j;
        int x = 0, y = 0;
        foreach(var cmd in commands)
        {
            if(cmd == "RIGHT")
                x++;
            else if(cmd == "LEFT")
                y--;
            else if(cmd == "UP")
                x--;
            else
                y++;
        }
        return matrix[x][y];
    }
}