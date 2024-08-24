/*                BRUTE FORCE SOLUTION                      */
// public class Solution {
//     public string NearestPalindromic(string n) {
//         var lowestVal = string.Empty;
//         var breakVal = 0;
//         for(var i = Int64.Parse(n) - 1; i >= 0; i--)
//         {
//             var chars = i.ToString().ToCharArray();
//             Array.Reverse(chars);
//             var reversed = new string(chars);
//             if(reversed == i.ToString())
//             {
//                 lowestVal = reversed;
//                 breakVal = Math.Abs(int.Parse(lowestVal) - int.Parse(n));
//                 break;
//             }
//         }
//         var highestVal = string.Empty;
//         var stop = 0;
//         var broke = false;
//         for(var i = Int64.Parse(n) + 1; i < 1e+18; i++)
//         {
//             stop++;
//             if(stop == breakVal)
//             {
//                 broke = true;
//                 break;
//             }
//             var chars = i.ToString().ToCharArray();
//             Array.Reverse(chars);
//             var reversed = new string(chars);
//             if(reversed == i.ToString())
//             {
//                 highestVal = reversed;
//                 break;
//             }
//         }
//         return (broke) ? lowestVal : highestVal;
//     }
// }
public class Solution
{
    public string NearestPalindromic(string n)
    {
        if (Int64.Parse(n) <= 10)
            return (Int64.Parse(n) - 1).ToString();
        long sub = Int64.Parse(n.Substring(0, (n.Length + 1) / 2)) + 2;
        long mindiff = 999999999;
        long closest = 0;
        for (long i = 0; i < 5; i++)
        {
            long pal = 0;
            switch (i)
            {
                case 0:
                case 1:
                case 2:
                    sub--;
                    if (sub.ToString().Length < n.Length / 2)
                        continue;
                    pal = Int64.Parse(sub.ToString() + new string(sub.ToString().Substring(0, n.Length / 2).Reverse().ToArray()));
                    if (pal == Int64.Parse(n))
                        continue;
                    break;
                case 3:
                    pal = (long)Math.Pow(10, n.Length - 1) + 1;
                    if (pal == Int64.Parse(n))
                        continue;
                    break;
                case 4:
                    pal = (long)Math.Pow(10, n.Length - 1) - 1;
                    if (pal == Int64.Parse(n))
                        continue;
                    break;
            }
            Check(pal, ref mindiff, ref closest, n);
        }
        return closest.ToString();
    }
    public void Check(long pal, ref long mindiff, ref long closest, string str)
    {
        long abs = Math.Abs(pal - Int64.Parse(str));
        if (abs <= mindiff)
        {
            mindiff = abs;
            closest = pal;
        }
    }
}