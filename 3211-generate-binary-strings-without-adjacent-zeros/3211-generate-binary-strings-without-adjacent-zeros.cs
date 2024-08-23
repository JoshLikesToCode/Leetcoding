public class Solution {
    private IList<string> _res;

    public IList<string> ValidStrings(int n) {
        _res = new List<string>();
        var builder = new StringBuilder();
        BackTrack(_res, builder, 0, n);
        return _res;
    }

    public void BackTrack(IList<string> list, StringBuilder builder, int idx, int n)
    {
        if(idx == n)
        {
         list.Add(builder.ToString());
         return;
        }

        var prev = '1';
        if(builder.Length > 0)
            prev = builder[builder.Length - 1];
        builder.Append('1');
        BackTrack(list, builder, idx + 1, n);
        builder.Remove(idx, 1);
        if(prev == '1')
        {
            builder.Append('0');
            BackTrack(list, builder, idx + 1, n);
            builder.Remove(idx, 1);
        }
    }
}