public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        var set = new HashSet<int>();
        var res = new List<int>();
        foreach(var arr in grid)
            foreach(var n in arr)
                    if(set.Contains(n))
                        res.Add(n);
                    else
                        set.Add(n);
        var limit = set.Max();
        for(var i = 1; i < limit; i++)
            if(!set.Contains(i))
                res.Add(i);
        if(res.Count != 2)
            res.Add(limit + 1);
        return res.ToArray();
    }
}