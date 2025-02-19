public class Solution {
    private List<string> _happy;
    
    public string GetHappyString(int n, int k) {
        _happy = new List<string>();
        BackTrack(n, "");
        if(_happy.Count < k)
            return "";
        _happy.Sort();
        return _happy[k - 1];
    }

    public void BackTrack(int n, string curr)
    {
        if(curr.Length == n)
        {
            _happy.Add(curr);
            return;
        }
        for(var c = 'a'; c <= 'c'; c++)
        {
            if(curr.Length > 0 && curr[^1] == c)
                continue;
            BackTrack(n, curr + c);
        }
    }
}