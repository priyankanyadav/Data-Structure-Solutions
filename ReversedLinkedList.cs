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
        ListNode prev = null;//previous node
        ListNode curr = head;// current node

        while(curr != null)
        {
          ListNode nextNode = curr.next;//save next
          curr.next = prev;//reverse pointer
          prev = curr;//moove prev forward
          curr = nextNode;// move curr forward
        }
        return prev;
    }
}
