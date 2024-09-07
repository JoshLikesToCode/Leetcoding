/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    public bool IsSubPath(ListNode head, TreeNode root) {
        if(root == null)
            return false;
        var res = DFS(root, head);
        res = res || IsSubPath(head, root.left);
        res = res || IsSubPath(head, root.right);
        return res;
    }

    public bool DFS(TreeNode node, ListNode head)
    {
        if(head == null) // end of list
            return true;
        if(node == null) // end of a tree
            return false;
        var res = false;
        if(node.val == head.val)
        {
            res = DFS(node.left, head.next);
            res = res || DFS (node.right, head.next);
        }
        return res;
    }
}