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
        var val1 = l1.val;
        var val2 = l2.val;
        var c = val1 + val2;
        var digit = c % 10;
        var k = c / 10 > 0 ? 1 : 0;
        ListNode l3 = new ListNode(digit);
        var result = l3;
        l1 = l1.next;
        l2 = l2.next;

        while (l1 != null && l2 != null) {
            val1 = l1 == null ? 0 : l1.val;
            val2 = l2 == null ? 0 : l2.val;

            c = val1 + val2 + k;
            digit = c % 10;
            k = c / 10 > 0 ? 1 : 0;

            var temp = new ListNode(digit);
            l3.next = temp;
            temp = l3.next;
            l3 = temp;
            l1 = l1.next;
            l2 = l2.next;
        }

        while( l1 != null){
            val1 = l1 == null ? 0 : l1.val;
            val2 =  0 ;

            c = val1 + val2 + k;
            digit = c % 10;
            k = c / 10 > 0 ? 1 : 0;

            var temp = new ListNode(digit);
            l3.next = temp;
            temp = l3.next;
            l3 = temp;
            l1 = l1.next;           
        }

        while( l2 != null){
            val2 = l2.val;
            val1 =  0 ;
            
            c = val1 + val2 + k;
            digit = c % 10;
            k = c / 10 > 0 ? 1 : 0;

            var temp = new ListNode(digit);
            l3.next = temp;
            temp = l3.next;
            l3 = temp;
            l2 = l2.next;           
        }

        if (k == 1) {
            var temp = new ListNode(1);
            l3.next = temp;
        }

        return result;
    }
}
