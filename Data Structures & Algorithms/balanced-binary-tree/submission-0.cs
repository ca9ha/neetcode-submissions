/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) {
        var isBalanced = true;
        getHeight(root, ref isBalanced);

        return isBalanced;
    }

    public int getHeight(TreeNode node, ref bool isBalanced) {
        if (node == null) {         
            return 0;
        }

        var left = getHeight(node.left, ref isBalanced);
        var right = getHeight(node.right, ref isBalanced);

        if(Math.Abs(left - right) > 1){
            isBalanced = false;
        } 
        return 1 + Math.Max(left, right);
    }
}
