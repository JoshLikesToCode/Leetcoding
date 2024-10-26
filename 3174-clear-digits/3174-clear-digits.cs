public class Solution {
    public string ClearDigits(string s) {
        var stack = new Stack<char>();
        foreach(var c in s)
        {
            if(stack.Count != 0)
            {
                if(Char.IsDigit(c))
                    stack.Pop();
                else
                    stack.Push(c);
            }
            else
                stack.Push(c);
        }
        var res = string.Empty;
        while(stack.Count != 0)
            res = res.Insert(0, stack.Pop() + "");
        return res;
    }
}