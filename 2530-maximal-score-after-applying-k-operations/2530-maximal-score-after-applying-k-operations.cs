public class Solution {
    public long MaxKelements(int[] nums, int k) {
        long res = 0L;
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b - a));
        foreach(var n in nums)
            pq.Enqueue(n, n);
        while(pq.Count != 0  && k-- > 0)
        {
            var max = pq.Dequeue();
            res += max;
            var ele = (int) Math.Ceiling(max / 3.0);
            pq.Enqueue(ele, ele);
        }
        return res;
    }
}