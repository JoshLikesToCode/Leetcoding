public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var res = new List<IList<int>>();
        Array.Sort(candidates);
        BackTrack(0, candidates, target, new List<int>(), res);
        return res;
    }

    private void BackTrack(int index, int[] candidates, int target, List<int> curr, IList<IList<int>> res) {
        if (target == 0) 
        {
            res.Add(new List<int>(curr));
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            // skip dupes
            if (i > index && candidates[i] == candidates[i - 1]) 
                continue;

            // no combo here
            if (candidates[i] > target) 
                break;

            curr.Add(candidates[i]);
            BackTrack(i + 1, candidates, target - candidates[i], curr, res);
            curr.RemoveAt(curr.Count - 1); // Backtrack
        }
    }
}