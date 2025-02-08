public class NumberContainers {

    private Dictionary<int, int> _indexToNumDict;
    private Dictionary<int, SortedSet<int>> _numToIndexes;

    public NumberContainers() 
    {
        _indexToNumDict = new Dictionary<int, int>();
        _numToIndexes = new Dictionary<int, SortedSet<int>>();
    }
    
    public void Change(int index, int number) {
        if(_indexToNumDict.ContainsKey(index))
        {
            int previousNum = _indexToNumDict[index];
            _numToIndexes[previousNum].Remove(index);
            if(_numToIndexes[previousNum].Count == 0)
                _numToIndexes.Remove(previousNum);      
        }
        _indexToNumDict[index] = number; 
        if(!_numToIndexes.ContainsKey(number))
            _numToIndexes[number] = new SortedSet<int>();
        _numToIndexes[number].Add(index);
    }
    
    public int Find(int number) {
        
        if(!_numToIndexes.ContainsKey(number))
            return -1;
        else
            return _numToIndexes[number].Min;
    }
}