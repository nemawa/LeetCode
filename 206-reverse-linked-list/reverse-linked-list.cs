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
        ListNode p = null;
        
        while (head != null) 
        {
            var n = head.next;
            head.next = p;
            p = head;
            head = n;
            
        }
        return p;
    }
}