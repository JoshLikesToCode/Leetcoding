public class Solution {
    public int GetLucky(string s, int k) {
        string sum = "";
        s.ToCharArray().ToList().ForEach(c => sum += (c - 96));
        while(k > 0)
        {
            int localSum = 0;
            foreach(char c in sum.ToCharArray())
                localSum += Convert.ToInt32(c - '0');
            sum = localSum.ToString();
            k--;
        }
        return Convert.ToInt32(sum);   
    }
}