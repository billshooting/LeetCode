/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return null;
        ListNode cur = head, res = new ListNode(0), cur1 = res;
        while(cur != null)
        {
            cur = GetNext(cur);
            cur1.next = cur;
            cur1 = cur1.next;
            cur = cur == null ? null : cur.next;
        }
        return res.next;
        
    }
    
    private ListNode GetNext(ListNode cur)
    {
        while(cur != null && cur.next != null && cur.val == cur.next.val)
        {
            int skip = cur.val;
            cur = cur.next.next;
            while(cur != null && cur.val == skip) cur = cur.next;
        }
        return cur;
    }
}