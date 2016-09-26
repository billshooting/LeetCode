/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int flag = 0;
        int value = 0, v1, v2;
        ListNode res = new ListNode(0);
        ListNode cur1 = l1, cur2 = l2, cur3 = res;
        while(cur1 != null || cur2 != null || flag != 0)
        {
            v1 = cur1 == null ? 0 : cur1.val;
            v2 = cur2 == null ? 0 : cur2.val;
            value = flag + v1 + v2;
            cur3.next = new ListNode(value % 10);
            flag = value / 10;
            cur3 = cur3.next;
            cur1 = cur1 == null ? null : cur1.next;
            cur2 = cur2 == null ? null : cur2.next;
        }
        return res.next;
    }
}