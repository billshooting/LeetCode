/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int flag = 0;
        int v1, v2, v3;
        ListNode *res = new ListNode(0);
        ListNode *cur1 = l1, *cur2 = l2, *cur3 = res;
        while(cur1 != nullptr || cur2 != nullptr || flag != 0)
        {
            v1 = cur1 == nullptr ? 0 : cur1->val;
            v2 = cur2 == nullptr ? 0 : cur2->val;
            v3 = v1 + v2 + flag;
            cur3->next = new ListNode(v3 % 10);
            flag = v3 / 10;
            cur1 = cur1 == nullptr ? nullptr : cur1->next;
            cur2 = cur2 == nullptr ? nullptr : cur2->next;
            cur3 = cur3->next;
        }
        return res->next;
    }
};