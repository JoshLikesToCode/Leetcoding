public class Solution {
    public string ConvertDateToBinary(string date) {
        var dateByParts = date.Split('-');
        var res = string.Empty;
        for(var i = 0; i < dateByParts.Length; i++)
        {
            res += Convert.ToString(int.Parse(dateByParts[i]), 2);
            if(i < dateByParts.Length - 1)
                res += "-";
        }
        return res;
    }
}