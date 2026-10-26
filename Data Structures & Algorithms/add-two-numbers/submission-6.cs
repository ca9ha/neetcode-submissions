/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        int k = 0;

        while (l1 != null || l2 != null || k > 0) {
            var val1 = l1 == null ? 0 : l1.val;
            var val2 = l2 == null ? 0 : l2.val;

            var c = val1 + val2 + k;
            var digit = c % 10;
            k = c / 10;

            var temp = new ListNode(digit);
            tail.next = temp;
            tail = temp;

            if (l1 != null)
                l1 = l1.next;

            if (l2 != null)
                l2 = l2.next;
        }

        return dummy.next;
    }
}
