/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        List<int> res = new List<int>();
        while(cur != null || s.Count != 0)
        {
            if(cur != null){
                s.Push(cur);
                cur = cur.left;
            }
            else
            {
                cur = s.Pop();
                res.Add(cur.val);
                cur = cur.right;
            }
        }
        return res;
    }
}