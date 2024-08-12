public class KthLargest {
    private readonly int _kth;
    private List<int> _sortedNums;

    public KthLargest(int k, int[] nums) {
        _kth = k;
        Array.Sort(nums);
        _sortedNums = nums.ToList();
    }
    
    public int Add(int val) {
        _sortedNums.Add(val);
        _sortedNums.Sort();
        return _sortedNums[_sortedNums.Count - _kth];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */