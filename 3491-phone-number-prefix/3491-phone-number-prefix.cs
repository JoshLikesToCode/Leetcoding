public class Solution {
    public bool PhonePrefix(string[] numbers) {
        for(var i = 0; i < numbers.Length; i++)
            for(var j = i + 1; j < numbers.Length; j++)
                if(numbers[j].StartsWith(numbers[i]) || numbers[i].StartsWith(numbers[j]))
                    return false;
        return true;
    }
}