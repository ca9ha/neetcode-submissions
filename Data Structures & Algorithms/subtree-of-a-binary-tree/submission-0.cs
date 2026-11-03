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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot == null) {
            return true;
        }

        if (root == null) {
            return false;
        }

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0) {
            var node = stack.Pop();

            if (node.val == subRoot.val && AreSameTrees(node, subRoot)) {
                return true;
            }

            if (node.right != null) {
                stack.Push(node.right);
            }

            if (node.left != null) {
                stack.Push(node.left);
            }
        }

        return false;
    }

    private bool AreSameTrees(TreeNode first, TreeNode second) {
        if (first == null || second == null) {
            return first == second;
        }

        return first.val == second.val && AreSameTrees(first.left, second.left) &&
               AreSameTrees(first.right, second.right);
    }
}
