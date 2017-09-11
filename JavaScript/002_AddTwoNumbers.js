/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
'use strict';

var addTwoNumbers = function(l1, l2) {
    let f = 0;
    let v1 = 0, v2 = 0, v3 = 0;
    let res = new ListNode(0);
    let cur1 = l1, cur2 = l2, cur3 = res;
    while(cur1 !== null || cur2 !== null || f !== 0)
    {
        v1 = cur1 === null ? 0 : cur1.val;
        v2 = cur2 === null ? 0 : cur2.val;
        v3 = f + v1 + v2;
        cur3.next = new ListNode(v3 % 10);
        f = v3 / 10;
        cur1 = cur1 === null ? null : cur1.next;
        cur2 = cur2 === null ? null : cur2.next;
        cur3 = cur3.next;
    }
    return res.next;
};
