public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < s.Length; i++)
            if(!dict.ContainsKey(s[i] - 97))
                dict[s[i] - 97] = i;
            else
                dict[s[i] - 97] = Math.Abs(dict[s[i] - 97] - i + 1);
        for(var i = 0; i < distance.Length; i++)
        {
            if(dict.ContainsKey(i) && dict[i] != distance[i])
                return false;
        }
        return true;
    }
}