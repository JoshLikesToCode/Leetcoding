/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
}
*/

public class Solution {
    public int[] ToArray(Node node) {
        var firstHalf = new List<int>();
        var secondHalf = new List<int>();
        var dummy = node;
        while(dummy != null)
        {
            dummy = dummy.prev;
            if(dummy != null)
                firstHalf.Add(dummy.val);
        }
        dummy = node;
        while(dummy != null)
        {
            dummy = dummy.next;
            if(dummy != null)
                secondHalf.Add(dummy.val);
        }
        var res = new List<int>();
        firstHalf.Reverse();
        foreach(var n in firstHalf)
            res.Add(n);
        res.Add(node.val);
        foreach(var n in secondHalf)
            res.Add(n);
        return res.ToArray();
    }
}