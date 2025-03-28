public class Solution {
    public int[] MaxPoints(int[][] grid, int[] queries) {
        int m = grid.Length, n = grid[0].Length;
        var coords = new List<int[]>();
        
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                coords.Add(new int[] { i, j, grid[i][j] }); // [row, col, value]

        
        coords.Sort((a, b) => a[2] - b[2]); // Sort coordinates by value in ascending order
        var sortedQueries = queries.Select((val, index) => new { val, index }).OrderBy(q => q.val).ToList();
        
        int k = coords.Count, idx = 0;
        var uf = new UnionFind(k);
        var res = new int[queries.Length];
        
        foreach (var query in sortedQueries) 
        {
            int queryVal = query.val, index = query.index;
            while (idx < k && coords[idx][2] < queryVal) 
            {
                int row = coords[idx][0];
                int col = coords[idx][1];
                ConnectWithNeighbors(row, col, queryVal, grid, uf, m, n);
                idx++;
            }
            
            if (grid[0][0] >= queryVal)
                res[index] = 0;
            else
            { 
                int count = uf._size[uf.Find(0)]; // Count cells connected to grid[0][0]
                res[index] = count;
            }
        }
        
        return res;
    }
    
    private void ConnectWithNeighbors(int row, int col, int queryVal, int[][] grid, UnionFind uf, int m, int n) {
        var directions = new int[][] { new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 } };
        
        foreach (var direction in directions) 
        {
            int newRow = row + direction[0], newCol = col + direction[1];
            if (newRow < 0 || newRow >= m || newCol < 0 || newCol >= n) 
                continue; // Out of bounds
            if (grid[newRow][newCol] >= queryVal) 
                continue; // Cell value larger than or equal to query value
            uf.Union(GetIndex(row, col, n), GetIndex(newRow, newCol, n));
        }
    }
    
    private int GetIndex(int row, int col, int n) 
    {
        return row * n + col;
    }
}

public class UnionFind {
    private readonly int[] _root;
    public readonly int[] _rank;
    public readonly int[] _size;

    public UnionFind(int size) {
        _root = new int[size];
        _rank = new int[size];
        _size = new int[size]; // Size[i] = size of group i
        
        for (int i = 0; i < size; i++) 
        {
            _root[i] = i;
            _rank[i] = 1;
            _size[i] = 1;
        }
    }
    
    public int Find(int x) 
    {
        if (_root[x] == x) 
            return x;
        _root[x] = Find(_root[x]); // Path compression
        return _root[x];
    }
    
    public bool Union(int x, int y) 
    {
        int rootX = Find(x), rootY = Find(y);
        
        if (rootX == rootY) 
            return false;
        
        if (_rank[rootX] < _rank[rootY]) 
        {
            _root[rootX] = rootY;
            _size[rootY] += _size[rootX];
        } 
        else if (_rank[rootX] > _rank[rootY]) 
        {
            _root[rootY] = rootX;
            _size[rootX] += _size[rootY];
        } 
        else 
        {
            _root[rootY] = rootX;
            _rank[rootX]++;
            _size[rootX] += _size[rootY];
        }
        return true;
    }
}