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
    public int DiameterOfBinaryTree(TreeNode root) {
        var diametr = 0;

        var height = getHeight(root, ref diametr);

        return diametr;
    }

    public int getHeight(TreeNode node, ref int diametr) {
        if (node == null) {         
            return 0;
        }

        var left = getHeight(node.left, ref diametr);
        var right = getHeight(node.right, ref diametr);

        diametr = Math.Max(diametr, left + right);

        return 1 + Math.Max(left, right);
    }
}
