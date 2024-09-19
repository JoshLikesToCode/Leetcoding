class Solution {
    public List<Integer> diffWaysToCompute(String expression) {
        List<Integer> res = new ArrayList<>();
        if(expression.indexOf('-') == -1 && expression.indexOf('+') == -1 && expression.indexOf('*') == -1)
        {
            res.add(Integer.parseInt(expression));
            return res;
        }
        for(int i = 0; i < expression.length(); i++)
        {
            char currChar = expression.charAt(i);
            if(currChar == '+' || currChar == '-' || currChar == '*')
            {
                String expr1 = expression.substring(0, i);
                String expr2 = expression.substring(i + 1);
                List<Integer> leftHalf = diffWaysToCompute(expr1);
                List<Integer> rightHalf = diffWaysToCompute(expr2);
                for(Integer v1 : leftHalf)
                    for(Integer v2 : rightHalf)
                    {
                        if(currChar == '+')
                            res.add(v1 + v2);
                        if(currChar == '-')
                            res.add(v1 - v2);
                        if(currChar == '*')
                            res.add(v1 * v2);
                    }
            }
        }
        return res;
    }
}