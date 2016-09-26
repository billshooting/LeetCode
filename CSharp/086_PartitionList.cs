/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode gtx = new ListNode(0), cur1 = gtx, ltx = new ListNode(0), cur2 = ltx, cur = head;
        while(cur != null)
        {
            if(cur.val < x)
            {
                cur2.next = cur;
                cur2 = cur2.next;
            }
            else
            {
                cur1.next = cur;
                cur1 = cur1.next;
            }
            cur = cur.next;
        }
        cur1.next = null;
        cur2.next = gtx.next;
        return ltx.next;
    }
}