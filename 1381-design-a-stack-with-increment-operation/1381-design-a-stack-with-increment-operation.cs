public class CustomStack {

    private readonly List<int> _stack;
    private readonly int _capacity;

    public CustomStack(int maxSize) {
        _stack = new List<int>();
        _capacity = maxSize;
    }
    
    public void Push(int x) {
        if(_stack.Count < _capacity)
            _stack.Add(x);
    }
    
    public int Pop() {
        if(_stack.Count != 0)
        {
            var val = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return val;
        }
        return -1;
    }
    
    public void Increment(int k, int val) {
        var kth = Math.Min(k, _stack.Count - 1);
        for(var i = 0; i < kth; i++)
            _stack[i] += val;
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */