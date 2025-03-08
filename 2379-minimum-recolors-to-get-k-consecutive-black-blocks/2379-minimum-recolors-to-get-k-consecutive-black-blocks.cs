public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int a = 0, count = 0, repaints = Int32.MaxValue;
        for(var b = 0; b < blocks.Length; b++)
        {
            if(blocks[b] == 'W')
                count++;
            if(b - a + 1 == k)
            {
                repaints = Math.Min(repaints, count);
                if(blocks[a] == 'W')
                    count--;
                a++;
            }
        }
        return repaints;
    }
}