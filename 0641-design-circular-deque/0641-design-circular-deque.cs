public class MyCircularDeque {

    private IList<int> _deque;
    private int _capacity;
    private int _currNumOfItems;

    public MyCircularDeque(int k) {
        _deque = new int[k].ToList();
        _capacity = k;
        _currNumOfItems = 0;
    }
    
    public bool InsertFront(int value) {
        if(_currNumOfItems == _capacity)
            return false;
        _deque.Insert(0, value);
        _currNumOfItems++;
        return true;
    }
    
    public bool InsertLast(int value) {
        if(_currNumOfItems == _capacity)
            return false;
        _deque.Insert(_deque.Count - 1, value);
        _currNumOfItems++;
        return true;
    }
    
    public bool DeleteFront() {
        if(_deque.Count == 0)
            return false;
        _deque.RemoveAt(0);
        _currNumOfItems--;
        return true;
    }
    
    public bool DeleteLast() {
        if(_deque.Count == 0)
            return false;
        _deque.RemoveAt(_deque.Count - 1);
        _currNumOfItems--;
        return true;
    }
    
    public int GetFront() {
        return _deque[0];
    }
    
    public int GetRear() {
        return _deque[_currNumOfItems + 1];
    }
    
    public bool IsEmpty() {
        return _currNumOfItems == 0;
    }
    
    public bool IsFull() {
        return _currNumOfItems == _capacity;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */