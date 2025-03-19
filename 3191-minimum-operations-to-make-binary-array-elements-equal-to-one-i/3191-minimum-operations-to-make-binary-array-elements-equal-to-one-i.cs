public class Solution {
    public int MinOperations(int[] nums) {
        var q = new LinkedList<int>();
        var res = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            while(q.Count != 0 && i > q.First() + 2)
                q.RemoveFirst();
            if((nums[i] + q.Count) % 2 == 0)
            {
                if(i + 2 >= nums.Length)
                    return -1;
                res++;
                q.AddLast(i);
            }
        }
        return res;
    }
}