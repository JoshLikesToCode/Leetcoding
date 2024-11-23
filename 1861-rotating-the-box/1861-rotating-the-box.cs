public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        var res = new char[box[0].Length][];
        for(var i = 0; i < box[0].Length; i++)
        {
            res[i] = new char[box.Length];
            Array.Fill(res[i], '.');
        }

        for(var i = 0; i < box.Length; i++)
        {
            var x = box[0].Length - 1;
            for(var j = box[0].Length - 1; j >= 0; j--)
            {
                if(box[i][j] == '#')
                {
                    res[x][box.Length - i - 1] = '#';
                    x--;
                }
                else if(box[i][j] == '*')
                {
                    res[j][box.Length - i - 1] = '*';
                    x = j - 1;
                }
            }
        }
        return res;
    }
}