public class Solution {
    public int DistributeCandies(int[] candyType) {
        Array.Sort(candyType);
        var uniqueness = 1;
        for(var i = 1; i < candyType.Length && uniqueness < candyType.Length / 2; i++)
            if(candyType[i] != candyType[i-1])
                uniqueness++;
        return Math.Min(uniqueness, candyType.Length / 2);
    }
}