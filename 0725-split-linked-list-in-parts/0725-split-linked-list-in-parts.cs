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
public class Solution {
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var res = new ListNode[k];
        var count = 0;
        var cur = head;
        while (cur != null) {
            count++;
            cur = cur.next;
        }
        cur = head;
        int size = count / k, extra = count % k; 
        for (int i = 0; i < k && cur != null; i++) {
            res[i] = cur;
            //Find the tail
            for (int j = 0; j < size + (extra > 0 ? 1 : 0) - 1; j++) cur = cur.next;
            //Cut the connection 
            ListNode temp = cur.next;
            cur.next = null;
            cur = temp;
            //Update the remaining space for extra nodes
            extra--;
        }
        return res;
    }
}