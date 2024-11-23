public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        var a = 0;
        foreach(var p in batteryPercentages)
            if(p > a)
                a++;
        return a;
    }
}