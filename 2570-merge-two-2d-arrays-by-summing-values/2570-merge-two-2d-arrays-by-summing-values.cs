public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
       var maxId = 0;
       var dict = new Dictionary<int, int>();
       foreach(var arr in nums1)
       {
            int key = arr[0], val = arr[1];
            maxId = Math.Max(maxId, key);
            if(!dict.ContainsKey(key))
                dict[key] = val;
            else
                dict[key] += val;
       } 
        foreach(var arr in nums2)
       {
            int key = arr[0], val = arr[1];
            maxId = Math.Max(maxId, key);
            if(!dict.ContainsKey(key))
                dict[key] = val;
            else
                dict[key] += val;
       } 
       var res = new List<int[]>();
       for(var i = 1; i <= maxId; i++)
        if(dict.ContainsKey(i))
            res.Add(new int[2]{i, dict[i]});
       return res.ToArray();
    }
}