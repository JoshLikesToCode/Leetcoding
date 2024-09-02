public class Solution {
    public int ChalkReplacer(int[] chalk, int k) {
        var ptr = 0;
        var sum = 0;
        while(sum < k)
        {
            if((sum + chalk[ptr]) > k)
                break;
            sum += chalk[ptr];
            ptr++;
            if(ptr == chalk.Length)
                ptr = 0;
        }
        return ptr;
    }
}