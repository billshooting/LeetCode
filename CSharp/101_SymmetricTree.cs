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
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        else return IsSameTree(root.left, root.right);
    }
    
    private bool IsSameTree(TreeNode p, TreeNode q){
        bool state = true;
        if(p == null && q == null) return true;
        else if(p == null && q != null) return false;
        else if(p != null && q == null) return false;
        else{
            if(p.val != q.val) return false;
        }
        state = state && IsSameTree(p.left, q.right);
        if(state == false) return false;
        return state && IsSameTree(p.right, q.left);
    }
}