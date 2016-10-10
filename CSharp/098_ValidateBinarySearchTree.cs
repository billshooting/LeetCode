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
    public bool IsValidBST(TreeNode root) {
        if(root == null) return true;
        List<int> val = new List<int>();
        InOrder(root, val);
        return IsValid(val);
    }
    
    public void InOrder(TreeNode root, List<int> val){
        if(root == null) return;
        InOrder(root.left, val);
        val.Add(root.val);
        InOrder(root.right, val);
    }
    
    public bool IsValid(List<int> val){
        int pre = val[0];
        bool state = true;
        for(int i = 1; i < val.Count; i++){
            state = state && pre < val[i];
            pre = val[i];
        }
        return state;
    }
}