public class Solution {
    public int FindComplement(int num) {
        return Convert.ToInt32(Convert.ToString(num, 2).Replace("1", "-").Replace("0", "1").Replace("-", "0"), 2);
    }
}