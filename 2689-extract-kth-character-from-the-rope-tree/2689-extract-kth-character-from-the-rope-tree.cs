/**
 * Definition for a rope tree node.
 * public class RopeTreeNode {
 *     public int len;
 *     public string val;
 *     public RopeTreeNode left;
 *     public RopeTreeNode right;
 *     public RopeTreeNode(int len=0, string val="", RopeTreeNode left=null, RopeTreeNode right=null) {
 *         this.len = len;
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private StringBuilder _res;

    public char GetKthCharacter(RopeTreeNode root, int k) {
        _res = new StringBuilder();
        GenerateRope(root, k);
        return _res[k - 1];
    }

    private void GenerateRope(RopeTreeNode node, int kth)
    {
        if(_res.Length > kth)
            return;
        if(node == null)
            return;
        if(node.left == null && node.right == null)
            _res.Append(node.val);
        GenerateRope(node.left, kth);
        GenerateRope(node.right, kth);
    }
}