class Solution {
    public boolean lemonadeChange(int[] bills) {
        if(bills[0] != 5)
            return false;
        int fives = 0;
        int tens = 0;
        for(int bill : bills)
        {
            if(bill == 5)
                fives++;
            else if(bill == 10)
            {
                fives--;
                tens++;
            }
            else
            {
                if(tens >= 1)
                {
                    fives--;
                    tens--;
                }
                else
                {
                    fives -= 3;
                }
                if(fives < 0 || tens < 0)
                    return false;
            }
        }
        return true;
    }
}