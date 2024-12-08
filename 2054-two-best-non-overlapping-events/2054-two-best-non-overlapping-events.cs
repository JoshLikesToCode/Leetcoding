public class Solution {
    public int MaxTwoEvents(int[][] events) {
        var times = new List<int[]>();

        foreach (var eventData in events) 
        {
            int start = eventData[0], end = eventData[1], value = eventData[2];
            times.Add(new int[] { start, 1, value }); 
            times.Add(new int[] { end + 1, 0, value }); 
        }

        times.Sort((a, b) => a[0] == b[0] ? a[1].CompareTo(b[1]) : a[0].CompareTo(b[0]));

        int max = 0, res = 0;
        foreach (var time in times) 
            if (time[1] == 1) 
                res = Math.Max(res, time[2] + max);
            else
                max = Math.Max(max, time[2]);

        return res;
    }
}