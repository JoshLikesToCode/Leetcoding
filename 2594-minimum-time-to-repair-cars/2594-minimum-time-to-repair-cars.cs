public class Solution {
    public long RepairCars(int[] ranks, int cars) {
        int min = ranks.Min(), max = ranks.Max();
        var freq = new int[max + 1];
        foreach(var rank in ranks)
        {
            min = Math.Min(min, rank);
            freq[rank]++;
        }
        long low = 1, high = 1L * min * cars * cars;
        while(low < high)
        {
            long mid = ((low + high) / 2), count = 0;
            for(var rank = 1; rank <= max; rank++)
                count += freq[rank] * (long)Math.Sqrt(mid / (long) rank);
            if(count >= cars)
                high = mid;
            else
                low = mid + 1;
        }
        return low;
    }
}