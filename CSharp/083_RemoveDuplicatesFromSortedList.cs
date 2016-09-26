/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode deleteDuplicates(ListNode head) {
        if(head == null) return null;
        ListNode cur = head, res = new ListNode(0), cur1 = res;
        int pre ;
        while(cur != null)
        {
            cur1.next = cur;
            cur1 = cur1.next;
            pre = cur.val;
            cur = cur.next;
            while(cur != null && cur.val == pre) cur = cur.next;
        }
        cur1.next = null;
        return res.next;
    }
}