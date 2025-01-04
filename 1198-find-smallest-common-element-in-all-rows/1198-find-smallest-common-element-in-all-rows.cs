public class Solution {
    public int SmallestCommonElement(int[][] mat) {
        List<int> list = null;
        foreach(var m in mat)
        {
            if(list == null)
                list = new List<int>(m);
            else
                list.RemoveAll(x => !m.Contains(x));
        }
        return (list.Count() == 0) ? -1 : list.Min();
    }
}