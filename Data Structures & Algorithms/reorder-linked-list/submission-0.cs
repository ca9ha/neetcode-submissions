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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head.next;

        // find the middle
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // reverse second part
        ListNode second = slow.next;
        slow.next = null;
        ListNode previous = null;
        while(second != null){
            ListNode temp = second.next;
            second.next = previous;
            previous = second;
            second = temp;
        }

        ListNode first = head;
        second = previous;

        while(second != null)
        {
            var left = first.next;
            var right = second.next;
            first.next = second;
            second.next = left;

            first = left;
            second = right;
        }
    }
}
