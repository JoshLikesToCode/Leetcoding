public class Solution {
    public bool HasGroupsSizeX(int[] deck) {
        if(deck.Length == 1)
            return false;
        var dict = new Dictionary<int, int>();
        foreach(var card in deck)
            if(!dict.ContainsKey(card))
                dict[card] = 1;
            else
                dict[card]++;
        var distinctValues = dict.Values.Distinct();
        var minInDistinctValues = distinctValues.Min();
        if(minInDistinctValues % 2 == 0)
        {
            if(distinctValues.Count() != 1)
            {
                foreach(var distinctValue in distinctValues)
                    if(distinctValue % 2 != 0)
                        return false;
            }
        }
        if(minInDistinctValues % 3 == 0)
        {
            if(distinctValues.Count() != 1)
            {
                foreach(var distinctValue in distinctValues)
                    if(distinctValue % 3 != 0)
                        return false;
            }
        }
        return true;
    }
}