public class Solution {
    public int MaxScore(string s) {
        int res = Int32.MinValue, numOfZeroes = 0, numOfOnes = 0;
        for(var i = 0; i < s.Length - 1; i++)
        {
            if(s.ToCharArray()[i] == '0')
                numOfZeroes++;
            for(int j = i + 1; j < s.Length; j++)
                if(s.ToCharArray()[j] == '1')
                    numOfOnes++;
            res = Math.Max(res, numOfZeroes + numOfOnes);
            numOfOnes = 0;
        }
        return res;
    }
}