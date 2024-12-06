public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        Array.Sort(banned);
        var res = 0;
        for(var i = 1; i <= n; i++)
        {
            if(ModifiedBinSearch(banned, i))
                continue;
            maxSum -= i;
            if(maxSum < 0)
                break;
            res++;
        }
        return res;
    }

    private bool ModifiedBinSearch(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;
        while(l <= r)
        {
            var m = l + (r - l) / 2;
            if(arr[m] == target)
                return true;
            if(arr[m] > target)
                r = m - 1;
            else
                l = m + 1;
        }
        return false;
    }
}