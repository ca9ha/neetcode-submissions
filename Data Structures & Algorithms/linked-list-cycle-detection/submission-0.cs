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
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> seen = new HashSet<ListNode>();
        ListNode current = head;

        while (current is not null) {
            if (seen.Contains(current)) {
                return true;
            }

            seen.Add(current);
            current = current.next;
        }

        return false;
    }
}
