public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int curr = 0, tot = 0, res = 0;
        for(var i = 0; i < gas.Length; i++)
        {
            tot += gas[i] - cost[i];
            curr += gas[i] - cost[i];
            if(curr < 0)
            {
                res = i + 1;
                curr = 0;
            }
        }
        return tot >= 0 ? res : -1;
    }
}