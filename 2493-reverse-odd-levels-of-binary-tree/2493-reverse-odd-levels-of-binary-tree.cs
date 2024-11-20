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
    public TreeNode ReverseOddLevels(TreeNode root) {
        var q = new Queue<TreeNode>();
        var stack = new Stack<int>();
        q.Enqueue(root);
        var odd = false;
        while(q.Count != 0)
        {
            var size = q.Count;
            var parent = new TreeNode(-1);
            for(var i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                if(!odd)
                {
                    if(node.left != null)
                        stack.Push(node.left.val);
                    if(node.right != null)
                        stack.Push(node.right.val);
                }
                else
                    node.val = stack.Pop();
                if(node.left != null)
                    q.Enqueue(node.left);
                                parent = node;
                if(node.right != null)
                    q.Enqueue(node.right);
            }
            odd = !odd;
        }
        return root;
    }
}