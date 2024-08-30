public class Solution {
    public int MinBitFlips(int start, int goal) {
        var xor = start ^ goal;
        var res = 0;
        while(xor > 0)
        {
            res += xor&1;
            xor >>= 1;
        }
        return res;
    }
}