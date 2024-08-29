public class Solution {
    public int RemoveStones(int[][] stones) {
        var adjList = new List<int>[stones.Length];
        for(var i = 0; i < stones.Length; i++)
            adjList[i] = new List<int>();

        for(var i = 0; i < stones.Length; i++)
            for(var j = i + 1; j < stones.Length; j++)
                if(stones[i][0] == stones[j][0] || stones[i][1] == stones[j][1])
                {
                    adjList[i].Add(j);
                    adjList[j].Add(i);
                }
        var numOfConnected = 0;
        var visited = new bool[stones.Length];
        
        for(var i = 0; i < stones.Length; i++)
            if(!visited[i])
            {
                DFS(adjList, visited, i);
                numOfConnected++;
            }
        return stones.Length - numOfConnected;
    }

    private void DFS(List<int>[] adjList, bool[] visited, int idx)
    {
        visited[idx] = true;
        foreach(var neighbor in adjList[idx])
            if(!visited[neighbor])
                DFS(adjList, visited, neighbor);
    }
}