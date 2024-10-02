public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var copy = new List<int>(arr).ToArray();
        Array.Sort(arr);
        var dict = new Dictionary<int, int>();
        var idx = 1;
        for(var i = 0; i < arr.Length; i++)
        {
            if(!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], idx);
                idx++;
            }
        }
        var res = new List<int>();
        for(var i = 0; i < copy.Length; i++)
            res.Add(dict[copy[i]]);
        return res.ToArray();
    }
}