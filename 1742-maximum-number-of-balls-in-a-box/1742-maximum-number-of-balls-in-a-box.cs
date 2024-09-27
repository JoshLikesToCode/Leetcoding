public class Solution {
    public int CountBalls(int lowLimit, int highLimit) {
        if(lowLimit == highLimit)
            return 1;
        var limit = highLimit;
        var arr = new int[limit + 1];
        var max = 0;
        for(var i = lowLimit; i <= highLimit; i++)
        {
            var sum = 0;
            var num = i;
            while(num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            arr[sum]++;
        }
        for(var i = 0; i < limit; i++)
            max = Math.Max(max, arr[i]);
        return max;
    }
}