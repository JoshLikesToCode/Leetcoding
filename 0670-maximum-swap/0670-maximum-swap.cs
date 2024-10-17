public class Solution {
    public int MaximumSwap(int num) {
        var strNum = num.ToString();
        var listOfIntsFromNum = new List<int>();
        for(var i = 0; i < strNum.Length; i++)
            listOfIntsFromNum.Add(strNum[i] - '0');
        var maxNum = listOfIntsFromNum.Max();
        var idxOfMax = listOfIntsFromNum.IndexOf(maxNum);
        if(idxOfMax != 0)
            strNum = Swap(0, idxOfMax, strNum.ToCharArray());
        return Convert.ToInt32(strNum);
    }

    public string Swap(int a, int b, char[] arr)
    {
        var tmp = arr[a];
        arr[a] = arr[b];
        arr[b] = tmp;
        return new string(arr);
    }
}