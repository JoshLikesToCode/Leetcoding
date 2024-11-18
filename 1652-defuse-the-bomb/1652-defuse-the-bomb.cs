public class Solution {
    public int[] Decrypt(int[] code, int k) {
        if(k == 0)
            return new int[code.Length];
        var res = new int[code.Length];
        for(var i = 0; i < res.Length; i++)
            if(k > 0)
                for(var j = i + 1; j < i + k + 1; j++)
                    res[i] += code[j % code.Length];
            else
                for(var j = i - Math.Abs(k); j < i; j++)
                    res[i] += code[(j + code.Length) % code.Length];
        return res;
    }
}