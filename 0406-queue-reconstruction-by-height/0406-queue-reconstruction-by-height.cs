public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        var peeps = people
                        .OrderByDescending(p => p[0])
                        .ThenBy(p => p[1]);
        var res = new List<int[]>();
        foreach(var p in peeps)
            res.Insert(p[1], p);
        return res.ToArray();                
    }
}