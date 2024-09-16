public class Solution {
public int FindMinDifference(IList<string> timePoints)
{
    var times = timePoints.Select(TimeOnly.Parse).Order().ToArray();
    var differences = times.Prepend(times[^1]).Zip(times, (a, b) => b - a);
    return (int)differences.Min().TotalMinutes;
}
}