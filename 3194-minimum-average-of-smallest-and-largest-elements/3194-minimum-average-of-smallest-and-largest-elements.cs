public class Solution {
    public double MinimumAverage(int[] nums) {
        var minHeap = new PriorityQueue<int, int>();
        var maxHeap = new PriorityQueue<int, int>();
        Array.Sort(nums);
        for(var idx = 0; idx < nums.Length; idx++)
            minHeap.Enqueue(nums[idx], idx);
        var heapIdx = 0;
        for(var idx = nums.Length - 1; idx >= 0; idx--)
            maxHeap.Enqueue(nums[idx], heapIdx++);
        var res = Double.MaxValue;
        for(var idx = 0; idx < nums.Length / 2; idx++)
            res = Math.Min(res, (double)(minHeap.Dequeue() + maxHeap.Dequeue()) / 2);
        return res;
    }
}