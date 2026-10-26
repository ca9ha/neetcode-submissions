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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> seen = new();
        ListNode current = head;

        while (current is not null) {
            seen.Add(current);
            current = current.next;
        }

        var removeIndex = seen.Count - n;

        if (removeIndex == 0) {
            return head.next;
        }

        seen[removeIndex - 1].next = seen[removeIndex].next;

        return head;
    }
}
