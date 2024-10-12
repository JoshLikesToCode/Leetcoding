public class Solution {
    public int MinGroups(int[][] intervals) {
        var start = Int32.MaxValue;
        var end = Int32.MinValue;
        foreach(var interval in intervals)
        {
            start = Math.Min(start, interval[0]);
            end = Math.Max(end, interval[1]);
        }

        var count = new int[end + 2];
        foreach(var interval in intervals)
        {
            count[interval[0]]++;
            count[interval[1] + 1]--;
        }

        var concurrentIntervals = 0;
        var maxConcurrentIntervals = 0;
        for(var i = start; i <= end; i++)
        {
            concurrentIntervals += count[i];
            maxConcurrentIntervals = Math.Max(maxConcurrentIntervals, concurrentIntervals);
        }
        return maxConcurrentIntervals;
    }
}