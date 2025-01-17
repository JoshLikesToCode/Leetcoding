public class Solution {
    public bool DoesValidArrayExist(int[] derived) {
        var og = new int[derived.Length + 1];
        og[0] = 0;
        for(var i = 0; i< derived.Length; i++)
            og[i + 1] = derived[i] ^ og[i];
        var zeroCheck = (og[0] == og[og.Length - 1]);
        og[0] = 1;
        for(var i = 0; i < derived.Length; i++)
            og[i + 1] = derived[i] ^ og[i];
        var oneCheck = og[0] == og[og.Length - 1];
        return zeroCheck || oneCheck;
    }
}