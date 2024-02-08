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
    public bool IsPalindrome(ListNode head) 
    {
        var slow = new ListNode();
        var fast = new ListNode();
        slow = head;
        fast = head;


        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }


        if (fast != null) slow = slow.next;
        slow = reverseList(slow);

        while (slow != null)
        {
            if (slow.val != head.val)
                return false;
            slow = slow.next;
            head = head.next;
        }

        return true;
    }

    private ListNode reverseList(ListNode head) {
        ListNode prev = null;

        while (head != null) 
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }

}