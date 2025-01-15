public class Solution {
    public int NumberOfAlternatingGroups(int[] colors) {
        var res = 0;
        for(var i = 0; i < colors.Length; i++)
        {
            int a = colors[i], b = colors[(i + 1) % colors.Length], c = colors[(i + 2) % colors.Length];
            if(a != b && b != c)
                res++;
        }
        return res;
    }
}