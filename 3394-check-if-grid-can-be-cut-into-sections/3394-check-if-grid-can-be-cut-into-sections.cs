public class Solution {
    public bool CheckValidCuts(int n, int[][] rectangles) {
        return Check(rectangles, 0) || Check(rectangles, 1);
    }

    private bool Check(int[][] rectangles, int d)
    {
        var count = 0;
        Array.Sort(rectangles, (a,b) => a[d] - b[d]);
        var furthest = rectangles[0][d + 2];
        for(var i = 1; i < rectangles.Length; i++)
        {
            var rect = rectangles[i];
            if(furthest <= rect[d])
                count++;
            furthest = Math.Max(furthest, rect[d + 2]);
        }
        return count >= 2;
    }
}