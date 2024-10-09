class Solution {
    public int minAddToMakeValid(String S) {
        Stack<Character> stack = new Stack<>();
        int length = S.length();
        int count = 0;
        
        for(int i = 0; i < length; i++)
        {
            char ch = S.charAt(i);
            if(!stack.isEmpty() && ch == ')' && stack.peek() == '(')
            {
                stack.pop();
                continue;
            }
            stack.push(ch);
        }
        return stack.size();
    }
}
