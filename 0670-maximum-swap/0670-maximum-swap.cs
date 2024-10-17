public class Solution {
    public int MaximumSwap(int num) {
        var strNum = num.ToString();
        int max = num;
        for(var i = 0; i < strNum.Length; i++)
        {
            for(var j = i + 1; j < strNum.Length; j++)
            {
                var charArr = strNum.ToCharArray();
                var tmp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = tmp;
                
                var tmpNum = Convert.ToInt32(new string(charArr));
                max = Math.Max(max, tmpNum);
            }
        }
        return max;
    }
}