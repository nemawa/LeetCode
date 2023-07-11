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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        var head = new ListNode(0);
        var start = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                start.next = list1;
                list1 = list1.next;
            }
            else
            {
                start.next = list2;
                list2 = list2.next;
            }
            start = start.next;
        }
        
        if (list1 == null) start.next = list2;
        if (list2 == null) start.next = list1;

        return head.next;
    }
}