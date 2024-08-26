/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        var res = new List<int>();
        Stack<Node> stack = new Stack<Node>();
        if(root == null)
            return res;
        else
            stack.Push(root);
        while(stack.Count > 0)
        {
            Node node = stack.Pop();
            res.Add(node.val);
            for(int i = 0; i < node.children.Count; i++)
                stack.Push(node.children[i]);
        }
        res.Reverse();
        return res;
    }
}