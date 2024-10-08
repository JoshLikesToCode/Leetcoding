public class Solution {
    public int MinSwaps(string s) {
        var stack = new Stack<char>();
        var unbalanced = 0;
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == '[')
                stack.Push(s[i]);
            else
                if(stack.Count != 0)
                    stack.Pop();
                else
                    unbalanced++;
        }
        return (unbalanced + 1) / 2;
    }
}