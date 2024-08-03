public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        if(target.Length != arr.Length)
            return false;
        Array.Sort(target);
        Array.Sort(arr);
        bool res = Enumerable.SequenceEqual(target, arr);
        return res;
    }
}