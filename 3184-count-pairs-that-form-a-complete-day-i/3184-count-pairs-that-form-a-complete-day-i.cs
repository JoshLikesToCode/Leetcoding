public class Solution {
    public int CountCompleteDayPairs(int[] hours) {
        var res = 0;
        for(var i = 0; i < hours.Length; i++)
        {
            var val1 = hours[i];
            for(var j = i + 1; j < hours.Length; j++)
            {
                var val2 = hours[j];
                if((val1+val2) % 24 == 0)
                    res++;
            }
        }
        return res;
    }
}