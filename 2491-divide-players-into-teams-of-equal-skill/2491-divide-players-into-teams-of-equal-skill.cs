public class Solution {
    public long DividePlayers(int[] skill) {
       Array.Sort(skill);
       var target = skill[0] + skill[skill.Length - 1];
       var chemistry = 0L;

       for(var i = 0; i < skill.Length / 2; i++)
       {
            if(skill[i] + skill[skill.Length - i - 1] != target)
                return - 1;
            chemistry += (long) skill[i] * (long) skill[skill.Length - i - 1];
       }
       return chemistry;
    }
}