public class Solution {
    public int SmallestChair(int[][] times, int targetFriend) {
        var timesWithIndex = new int[times.Length][];
        for (var i = 0; i < times.Length; i++)
            timesWithIndex[i] = new int[] { times[i][0], times[i][1], i };
        Array.Sort(timesWithIndex, (a, b) => a[0].CompareTo(b[0]));

        var occupied = new bool[times.Length];
        var chairAssignment = new int[times.Length]; 
        var leavingList = new List<Tuple<int, int>>();  
        
        for (var i = 0; i < times.Length; i++) 
        {
            int arrivalTime = timesWithIndex[i][0], leavingTime = timesWithIndex[i][1], friendIndex = timesWithIndex[i][2];

            leavingList.RemoveAll(l => 
            {
                if (l.Item1 <= arrivalTime) 
                {
                    occupied[l.Item2] = false;  
                    return true;
                }
                return false;
            });
            var assignedChair = -1;
            for (var j = 0; j < times.Length; j++) 
            {
                if (!occupied[j]) 
                {
                    assignedChair = j;
                    occupied[j] = true;  
                    break;
                }
            }
            chairAssignment[friendIndex] = assignedChair;
            if (friendIndex == targetFriend)
                return assignedChair;

            leavingList.Add(Tuple.Create(leavingTime, assignedChair));
        }
        return -1;
    }
}