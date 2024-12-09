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
    public ListNode DeleteMiddle(ListNode head) {
        ListNode fast = head;
        ListNode slow = new (0, head);
        
        if(head.next == null) return null;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

        }
        
        slow.next = slow.next.next;
        
        return head;
    }
}