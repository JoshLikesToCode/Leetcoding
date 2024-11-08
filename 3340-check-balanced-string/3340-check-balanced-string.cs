public class Solution {
    public bool IsBalanced(string num) {
        int oddSum = 0, evenSum = 0;
        for(var i = 0; i < num.Length; i++)
            if(i % 2 == 0)
                evenSum += Int32.Parse(num[i] + "");
            else
                oddSum += Int32.Parse(num[i] + "");
        return (oddSum == evenSum);
    }
}