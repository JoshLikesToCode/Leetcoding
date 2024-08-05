public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var freqMap = new Dictionary<string, int>();
        foreach(var s in arr)
            if(!freqMap.ContainsKey(s))
                freqMap[s] = 1;
            else
                freqMap[s]++;
            foreach(var s in arr)
            {
                if(freqMap[s] == 1)
                    k--;
                if(k==0)
                    return s;
            }
            return "";
    }
}