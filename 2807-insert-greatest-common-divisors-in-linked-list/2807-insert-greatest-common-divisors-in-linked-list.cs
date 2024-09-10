public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        var curr = head;

        while (curr.next != null) {
            var gcd = GetGCD(curr.val, curr.next.val);
            var mid = new ListNode(gcd, curr.next);

            var originNext = curr.next;
            curr.next = mid; 
            curr = originNext;
        }

        return head;
    }

    private static int GetGCD(int a, int b) {
        if (a == b) {
            return a;
        }

        if (a > b) {
            return GetGCD(a - b, b);
        }

        return GetGCD(a, b - a);
    }
}