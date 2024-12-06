public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        var count = 0;
        for(var i = 0; count < nums.Length; i++)
        {
            int curr = i, prev = nums[i];
            do
            {
                var nxt = (curr + k) % nums.Length;
                var tmp = nums[nxt];
                nums[nxt] = prev;
                prev = tmp;
                curr = nxt;
                count++;
            } while (i != curr);
        }
    }
}