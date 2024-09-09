public class Solution {
    public bool CanAliceWin(int[] nums) {
        int aliceSum = 0, bobSum = 0;
        foreach(var n in nums)
        {
            if(n.ToString().Length >= 2)
                bobSum += n;
            else
                aliceSum += n;
        }
        return aliceSum != bobSum;
    }
}