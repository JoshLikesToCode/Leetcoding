public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        var pq = new PriorityQueue<(int count, char ch), int>();
        if(a > 0)
            pq.Enqueue((a, 'a'), -a);
        if(b > 0)
            pq.Enqueue((b, 'b'), -b);
        if(c > 0)
            pq.Enqueue((c, 'c'), -c);

        var res = new List<char>();
        
        while(pq.Count > 0)
        {
            var (count1, ch1) = pq.Dequeue();
            if(res.Count >= 2 && res[^1] == ch1 && res[^2] == ch1)
            {
                if(pq.Count == 0)
                    break;
                var (count2, ch2) = pq.Dequeue();
                res.Add(ch2);
                count2--;
                if(count2 > 0)
                    pq.Enqueue((count2, ch2), -count2);
                pq.Enqueue((count1, ch1), -count1);
            }
            else
            {
                res.Add(ch1);
                count1--;
                if(count1 > 0)
                    pq.Enqueue((count1, ch1), -count1);
            }
        }
        return new string(res.ToArray());
    }
}