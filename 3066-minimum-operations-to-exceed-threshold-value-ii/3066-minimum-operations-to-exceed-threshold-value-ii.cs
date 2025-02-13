public class Solution {
    public int MinOperations(int[] nums, int k) {
        var res = 0;
        var q = new PriorityQueue<int, int>();
        foreach(var n in nums)
            q.Enqueue(n, n);
        while(q.Count > 1 && q.Peek() < k)
        {
            var val = q.Dequeue() * 2 + q.Dequeue();
            q.Enqueue(val, val);
            res++;
        }
        return res;
    }
}