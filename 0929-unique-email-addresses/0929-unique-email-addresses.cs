public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var res = 0;
        var hs = new HashSet<string>();
        foreach(var email in emails)
        {
            var e = email.Split('@');
            string local = e[0], domain = e[1];
            local = new string(local.Where(x => x != '.').ToArray());
            var plusIdx = local.IndexOf('+');
            if(plusIdx != -1)
                local = local.Substring(0, plusIdx);
            hs.Add(local + "@" + domain);
        }
        return hs.Count;
    }
}