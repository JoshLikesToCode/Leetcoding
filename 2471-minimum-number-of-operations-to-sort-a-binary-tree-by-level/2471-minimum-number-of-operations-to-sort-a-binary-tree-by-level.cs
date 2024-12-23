public class Solution {
    public int MinimumOperations(TreeNode root) {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var min = 0;
        while (q.Count > 0) 
        {
            int size = q.Count, idx = 0;
            var arr = new int[size];
            for (var i = 0; i < size; i++) 
            {
                var curr = q.Dequeue();
                arr[idx++] = curr.val;
                
                if (curr.left != null)
                    q.Enqueue(curr.left);
                
                if (curr.right != null)
                    q.Enqueue(curr.right);
            }
            min += SelectionSort(arr);
        }
        return min;
    }
    
    private int SelectionSort(int[] arr) {
        var count = 0;
        for (var i = 0; i < arr.Length - 1; i++) 
        {
            int minIdx = i;
            for (var j = i + 1; j < arr.Length; j++)
                if (arr[j] < arr[minIdx])
                    minIdx = j;
        
            if (minIdx != i) 
            {
                var tmp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = tmp;          
                count++;
            }
        }
        return count;
    }
}