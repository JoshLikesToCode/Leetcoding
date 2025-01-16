public class Solution {
    public int MaxDistance(int[] colors) {
        int res = 0, count = 0;
        for(var i = 0; i < colors.Length; i++)
            for(var j = i + 1; j < colors.Length; j++)
                if(colors[i] != colors[j])
                    res = Math.Max(res, Math.Abs(j - i));
        return res;
    }
}