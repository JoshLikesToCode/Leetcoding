/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {

    private int _idx;

    public TreeNode RecoverFromPreorder(string traversal) {
        _idx = 0;
        return DFS(traversal, 0);    
    }
    
    private TreeNode DFS(string s, int depth)
    {
        if(_idx >= s.Length)
            return null;
        var count = 0;
        while(
            (_idx + count) < s.Length
            && s[_idx + count] == '-'
        )
            count++;
        if(count != depth)
            return null;
        _idx += count;
        var val = 0;
        while(
            _idx < s.Length
            && char.IsDigit(s[_idx])
        )
            val = val * 10 + (s[_idx++] - '0');
        var node = new TreeNode(val);
        node.left = DFS(s, depth + 1);
        node.right = DFS(s, depth + 1);
        return node;
    }
}