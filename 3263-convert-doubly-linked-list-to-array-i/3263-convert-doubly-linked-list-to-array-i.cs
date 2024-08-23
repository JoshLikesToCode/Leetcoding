/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
}
*/

public class Solution {
    public int[] ToArray(Node head) {
        var res = new List<int>();
        var dummy = head;
        while(dummy != null)
        {
            res.Add(dummy.val);
            dummy = dummy.next;
        }
        return res.ToArray();
    }
}