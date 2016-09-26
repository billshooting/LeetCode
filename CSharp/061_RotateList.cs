/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null) return head;
        if(k == 0) return head;
        int n = k, count = 0;
        ListNode front = head, back;
        while(n > 0)
        {
            front = head;
            while(n > 0)
            {
                if(front == null) break;
                count++;
                front = front.next;
                n--;
            }
            if(front == null && n == 0) return head;
            if(n != 0)
            {
                n = k % count;
                if(n == 0) return head;
            }
        }
        back = head;
        while(front.next != null)
        {
            front = front.next;
            back = back.next;
        }
        ListNode newHead = back.next;
        front.next = head;
        back.next = null;
        return newHead;
        
    }
}