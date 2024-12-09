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

        ListNode fast = new();
        ListNode slow = new();

        fast = head.next;
        slow = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode mid = slow.next;
        slow.next = null;

        ListNode current = mid;
        ListNode prev = null;

        while (current != null)
        {
            ListNode temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;

        }

        ListNode  second = prev;
        ListNode first = head;
        while (second != null)
        {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
        return;
    }
}