public class Solution {
    public bool CheckPowersOfThree(int n) {
        if(n == 1)
            return true;
        if((n-1) % 3 == 0)
            return CheckPowersOfThree((n-1)/3);
        if(n % 3 == 0)
            return CheckPowersOfThree(n/3);
        return false;
    }
}