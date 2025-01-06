public class Solution {
    public int[] MinOperations(string boxes) {
        var res = new int[boxes.Length];
        for(var i = 0; i < boxes.Length; i++)
        {
            var sum = 0;
            for(var j = 0; j < boxes.Length; j++)
            {
                var val = boxes[j] - '0';
                if(i != j && val == 1)
                    sum += Math.Abs(i - j);
            }
            res[i] = sum;
        }
        return res;
    }
}