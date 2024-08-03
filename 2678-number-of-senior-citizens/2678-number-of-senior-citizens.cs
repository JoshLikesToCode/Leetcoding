public class Solution {
    public int CountSeniors(string[] details) {
        var res = 0;
        foreach(string deets in details)
        {
            var d = deets.Substring(11, 2);
            if(int.Parse(d) > 60)
                res++;
        }
        return res;
    }
}