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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        var dummy1 = new ListNode(0);
        dummy1.next = head;
        var dummy2 = dummy1;
        while(dummy2.next != null)
        {
            if(nums.Contains(dummy2.next.val))
                dummy2.next = dummy2.next.next;
            else
                dummy2 = dummy2.next;
        }
        return dummy1.next;
    }
}