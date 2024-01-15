/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
      
       HashSet<ListNode> l1 = new HashSet<ListNode>();
       
       while (headA != null)
       {
           l1.Add(headA);
           headA = headA.next;
       }

       while (headB != null)
        {
            if (l1.Contains(headB)) return headB;
            headB = headB.next;
        }
        return null;
       
    }
}