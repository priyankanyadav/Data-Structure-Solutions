//You are given the heads of two sorted linked lists list1 and list2.

//Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

//Return the head of the merged linked li


public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Create a dummy node to help simplify the merge process
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        // While both lists have nodes
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                current.next = list1;  // Attach list1 node
                list1 = list1.next;    // Move list1 pointer
            } else {
                current.next = list2;  // Attach list2 node
                list2 = list2.next;    // Move list2 pointer
            }
            current = current.next;    // Move current pointer
        }

        // Attach any remaining nodes (only one of these will have nodes)
        if (list1 != null) {
            current.next = list1;
        } else {
            current.next = list2;
        }

        // Return the merged list, which starts at dummy.next
        return dummy.next;
    }
}
