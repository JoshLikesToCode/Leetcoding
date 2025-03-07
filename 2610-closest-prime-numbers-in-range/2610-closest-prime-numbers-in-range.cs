public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        var primes = new List<int>();
        for(var i = left; i <= right; i++)
            if(i % 2 == 0 && i > 2)
                continue;
            else if(IsPrime(i))
                primes.Add(i);
        var res = new int[2]{-1,-1};
        if(primes.Count <= 2)
            return res;
        var lowestGap = Math.Abs(primes.Max() - primes.Min());
        for(var i = 0; i < primes.Count; i++)
        {
            var v1 = primes[i];
            for(var j = i + 1; j < primes.Count; j++)
            {
                if(Math.Abs(v1 - primes[j]) < lowestGap)
                {
                    res[0] = v1;
                    res[1] = primes[j];
                    lowestGap = Math.Abs(v1 - primes[j]);
                }
            }
        }
        return res;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));
            
        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;
        
        return true;        
    }
}