public class Solution {
    private List<IList<int>> _res;
    
    private int GetHeight(TreeNode root)
    {
        if(root == null)
            return -1;
        var l = GetHeight(root.left);
        var r = GetHeight(root.right);
        var currHeight = Math.Max(l, r) + 1;
        if(_res.Count == currHeight)
            _res.Add(new List<int>());
        _res[currHeight].Add(root.val);
        return currHeight;
    }
    public IList<IList<int>> FindLeaves(TreeNode root) {
        _res = new List<IList<int>>();
        GetHeight(root);
        return _res;
    }
}