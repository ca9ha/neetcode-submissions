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
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        ListNode current = head;

        while (current is not null) {
            // Сохраняем оставшуюся часть списка.
            ListNode next = current.next;

            // Разворачиваем одну связь.
            current.next = previous;

            // Перемещаемся дальше.
            previous = current;
            current = next;
        }

        return previous;
    }
}
