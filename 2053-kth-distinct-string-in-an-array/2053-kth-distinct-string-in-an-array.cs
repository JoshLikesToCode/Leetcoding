public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var set = new List<string>();
        foreach(var val in arr)
        {
            if(!set.Contains(val))
                set.Add(val);
            else
                set.Remove(val); 
        }
        if(k > set.Count)
            return "";
        return set[k-1];
    }
}