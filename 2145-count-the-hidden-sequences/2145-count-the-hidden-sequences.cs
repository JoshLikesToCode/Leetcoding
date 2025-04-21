public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        int a = 0, b = 0, curr = 0;
        foreach(var difference in differences)
        {
            curr += difference;
            a = Math.Min(a, curr);
            b = Math.Max(b, curr);
            if(b - a > upper - lower)
                return 0;
        }
        return (upper - lower)  - (b - a) + 1;
    }
}