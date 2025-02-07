public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        var res = new int[queries.Length];
        Dictionary<int, int> colors = new(queries.Length),
            colorCount = new (queries.Length);

        for(var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];
            int ballNum = query[0],
            newColor = query[1],
            prevColor = colors.GetValueOrDefault(ballNum);
            if(prevColor > 0 && --colorCount[prevColor] == 0)
                colorCount.Remove(prevColor);
            colors[ballNum] = newColor;
            colorCount[newColor] = colorCount.GetValueOrDefault(newColor) + 1;
            res[i] = colorCount.Count;
            
        }
        return res;
    }
}