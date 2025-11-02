/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
  *    public ListNode next;
   *   public ListNode(int val=0, ListNode next=null) {
    *      this.val = val;
     *     this.next = next;
      *}
  *}
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null)
            return head;

        ListNode current = head;
		ListNode previous = null;
		while(current != null){
			ListNode p1 = current.next;
			current.next = previous;
			previous = current;
			current = p1;
		}
		head = previous;
		return head;
        
    }
}
