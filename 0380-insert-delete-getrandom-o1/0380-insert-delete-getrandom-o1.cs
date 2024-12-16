public class RandomizedSet {
    readonly Dictionary<int, int> _idxValues;
    readonly Dictionary<int, int> _valuesIdx;
    readonly Random _random;
    int _count;

    public RandomizedSet()
    {
        _idxValues = new Dictionary<int, int>();
        _valuesIdx = new Dictionary<int, int>();
        _random = new Random();
        _count = 0;
    }

    public bool Insert(int val)
    {
        if (_valuesIdx.ContainsKey(val))
            return false;

        _valuesIdx.Add(val, _count);
        _idxValues.Add(_count, val);
        _count++;

        return true;
    }

    public bool Remove(int val)
    {
        if (!_valuesIdx.ContainsKey(val))
            return false;

        var valueIndex = _valuesIdx[val];
        if (valueIndex == _count - 1)
        {
            _idxValues.Remove(valueIndex);
            _valuesIdx.Remove(val);
            _count--;
            return true;
        }
        
        //Replace current index and values with last (index and value)
        _idxValues[valueIndex] = _idxValues[_count - 1];
        _valuesIdx[_idxValues[valueIndex]] = valueIndex;
        
        _valuesIdx.Remove(val);
        _idxValues.Remove(_count - 1);
        _count--;

        return true;
    }

    public int GetRandom()
    {
        return _idxValues[_random.Next(_count)];
    }
}


/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */