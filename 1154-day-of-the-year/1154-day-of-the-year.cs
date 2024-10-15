public class Solution {
    public int DayOfYear(string date) {
        var parsedDate = DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
        var dateYear = int.Parse(date.Split('-')[0]);
        var lastDate = new DateTime(dateYear, 12, 31);
        return (DateTime.IsLeapYear(dateYear) ? 366 : 365) - (lastDate - parsedDate).Days;
    }
}