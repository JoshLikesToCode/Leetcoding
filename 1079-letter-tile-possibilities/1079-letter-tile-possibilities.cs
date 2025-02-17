class Solution {

    public int NumTilePossibilities(string tiles) {
        var hs = new HashSet<string>();
        var visited = new bool[tiles.Length];
        for(int i = 0; i < tiles.Length; i++)
            BackTrack(tiles, new StringBuilder(), i, hs, visited);
        return hs.Count - 1; // - 1 for ""
    }
    
    public void BackTrack(string s, StringBuilder currSeq, int pos, HashSet<string> hs, bool[] visited)
    {
        hs.Add(currSeq.ToString());
        for(int i = 0; i < s.Length; i++)
        {
            if(visited[i])
                continue;
            visited[i] = true;
            var currChar = s[i];
            currSeq.Append(currChar);
            BackTrack(s, currSeq, i, hs, visited);
            currSeq.Length--;
            visited[i] = false;
        }
    }
}