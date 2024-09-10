public class Solution {
    public bool CanAliceWin(int[] nums) {
        int a = 0, b = 0;
        nums.ToList().ForEach( x => {
                if(x.ToString().Length == 1){ a += x; }
                else { b += x; }
            }       
        );
        return a != b;
    }
}