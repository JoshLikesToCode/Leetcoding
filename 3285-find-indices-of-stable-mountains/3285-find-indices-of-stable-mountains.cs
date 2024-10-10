public class Solution {
    public IList<int> StableMountains(int[] height, int threshold) {
        var res = new List<int>();
        for(var i = 1; i < height.Length; i++)
            if(height[i-1] > threshold)
                res.Add(i);
        return res;
    }
}