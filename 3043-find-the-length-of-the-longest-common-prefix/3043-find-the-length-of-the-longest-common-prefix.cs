public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        var res = 0;
        if(arr1.Length > arr2.Length)
        {
            for(var i = 0; i < arr2.Length; i++)
            {
                var mainComp = arr2[i].ToString();
                foreach(var n in arr1)
                    if(mainComp.StartsWith(n.ToString()))
                        res = Math.Max(res, n.ToString().Length);
            }
        }
        else
        {
            for(var i = 0; i < arr1.Length; i++)
            {
                var mainComp = arr1[i].ToString();
                foreach(var n in arr2)
                    if(mainComp.StartsWith(n.ToString()))
                        res = Math.Max(res, n.ToString().Length);
            }
        }
        return res;
    }
}