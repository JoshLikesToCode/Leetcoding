public class Solution {
    public IList<int> LexicalOrder(int n) {
        var res = new List<int>();
        var curr = 1;
        for(var i = 0; i < n; i++)
        {
            res.Add(curr);
            if(curr * 10 <= n)
                curr *= 10;
            else
            {
                while(curr % 10 == 9 || curr >= n)
                    curr /= 10;
                curr += 1;
            }
        }
        return res;
    }
}