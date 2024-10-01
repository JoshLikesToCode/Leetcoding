public class Solution {
    public bool CanArrange(int[] arr, int k) {
        var res = new int[k];
        foreach(var num in arr) {
            res[((num % k) + k) % k]++;
        }
        
        if (res[0] % 2 != 0) {
            return false;
        }

        for (var i = 1; i <= k / 2; i++) {
            if (res[i] != res[k - i]) {
                return false;
            }
        }
        return true;
    }
}