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
    public long KthLargestLevelSum(TreeNode root, int k) {
        var pq = new PriorityQueue<long, long>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count != 0)
        {
            var size = q.Count;
            long sum = 0L;
            for(var i = 0; i < size; i++)
            {
                var node = q.Dequeue();
                sum += node.val;
                if(node.left != null)
                    q.Enqueue(node.left);
                if(node.right != null)
                    q.Enqueue(node.right);
            }
            pq.Enqueue(sum, -sum);
        }
        if(pq.Count < k)
            return -1;
        for(var i = 0; i < k - 1; i++)
            pq.Dequeue();
        return pq.Dequeue();
    }
}