public class Solution {
    public bool CanChange(string start, string target) {
        int length = start.Length, startIdx = 0, targetIdx = 0;
        while(startIdx < length || targetIdx < length)
        {
            while(startIdx < length && start[startIdx] == '_')
                startIdx++;
            while(targetIdx < length && target[targetIdx] == '_')
                targetIdx++;
            if(startIdx == length || targetIdx == length)
                return startIdx == length && targetIdx == length;
            if(start[startIdx] != target[targetIdx] ||
                start[startIdx] == 'L' && startIdx < targetIdx ||
                start[startIdx] == 'R' && startIdx > targetIdx)
                    return false;
            startIdx++;
            targetIdx++;
        }
        return true;
    }
}