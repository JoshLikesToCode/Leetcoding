public class Solution {
    public bool CheckOnesSegment(string s) {
        bool found = false, segment = false;
        foreach(var c in s)
        {
            if(c == '1')
                found = true;
            else if(c == '0' && found)
                segment = true;
            if(c == '1' && segment)
                return false;
        }
        return true;
    }
}