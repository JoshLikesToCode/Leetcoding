public class Solution {
    public int PunishmentNumber(int n) {
        var res = 0;
        for(var i = 1; i <= n; i++)
            if(CanPartition(i * i, i))
                res += i * i;
        return res;   
    }

    public bool CanPartition(int n, int val)
    {
        if(val < 0 || n < val)
            return false;
        if(n == val)
            return true;
        return (CanPartition(n / 10, val - (n % 10)) ||
                CanPartition(n / 100, val - (n % 100)) ||
                CanPartition(n / 1000, val - (n % 1000))
        );
    }
}