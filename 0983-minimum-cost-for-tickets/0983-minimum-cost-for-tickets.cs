public class Solution {
    HashSet<int> isTravelNeeded = new HashSet<int>();

    public int MincostTickets(int[] days, int[] costs) {
        var lastDay = days[days.Length - 1];
        var dp = new int[lastDay + 1];
        Array.Fill(dp, -1);
        foreach(var day in days)
            isTravelNeeded.Add(day);
        return Solve(dp, days, costs, 1);
    }

    private int Solve(int[] dp, int[] days, int[] costs, int currDay)
    {
        if(currDay > days[days.Length - 1])
            return 0;
        if(!isTravelNeeded.Contains(currDay))
            return Solve(dp, days, costs, currDay + 1);
        if(dp[currDay] != -1)
            return dp[currDay];
        var oneDay = costs[0] + Solve(dp, days, costs, currDay + 1);
        var sevenDay = costs[1] + Solve(dp, days, costs, currDay + 7);
        int thirtyDay = costs[2] + Solve(dp, days, costs, currDay + 30);
        return dp[currDay] = Math.Min(oneDay, Math.Min(sevenDay, thirtyDay));
    }
}