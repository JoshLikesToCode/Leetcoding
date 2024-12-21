public class Solution {
    public bool EqualFrequency(string word) {
        var freqMap = new Dictionary<char, int>();
        foreach(var c in word)
            if(!freqMap.ContainsKey(c))
                freqMap[c] = 1;
            else
                freqMap[c]++;
        var thereCanOnlyBeOne = false;
        var val = -1;
        var moreThanSingleChars = freqMap.Select(x => x.Value).Where(x => x != 1);
        if(!moreThanSingleChars.Any())
            return true;
        foreach(var kvp in freqMap)
        {
            Console.WriteLine($"val = {val} and Kvp.Value = {kvp.Value}");
            if(val == -1)
            {
                val = kvp.Value;
                continue;
            }
            if(!thereCanOnlyBeOne && Math.Abs(val - kvp.Value) == 1)
            {
                thereCanOnlyBeOne = true;
                //val = kvp.Value;
                continue;
            }
            if(thereCanOnlyBeOne && Math.Abs(val - kvp.Value) >= 1)
                return false;
            val = kvp.Value;
        }
        return thereCanOnlyBeOne;
    }
}