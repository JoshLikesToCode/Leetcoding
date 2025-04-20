public class Solution {
    public int NumRabbits(int[] answers)
{
    Dictionary<int, int> counts = new();

    foreach (int answer in answers)
    {
        if (counts.ContainsKey(answer))
            counts[answer]++;
        else
            counts[answer] = 1;
    }

    int totalRabbits = 0;
    foreach (var kvp in counts)
    {
        int answer = kvp.Key;
        int count = kvp.Value;

        int groupSize = answer + 1;
        int groupsNeeded = (count + groupSize - 1) / groupSize; 
        totalRabbits += groupsNeeded * groupSize;
    }

    return totalRabbits;
}
