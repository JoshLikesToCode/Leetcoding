public class Solution {
    public int WateringPlants(int[] plants, int capacity) {
        int a = 1, b = 1, c = capacity;
        for(var i = 0; i < plants.Length - 1; i++)
            if(c - plants[i] >= plants[i+1])
            {
                c -= plants[i];
                a++;
                b++;
            }
            else
            {
                c = capacity;
                b += (2 * a) + 1;
                a++;
            }
        return b;
    }
}