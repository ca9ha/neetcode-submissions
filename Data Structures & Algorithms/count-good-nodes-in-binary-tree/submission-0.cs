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
    public int GoodNodes(TreeNode root) {
        var result = 0;

        Stack<(TreeNode node, int max)> stack = new Stack<(TreeNode node, int max)>();
        stack.Push((root, int.MinValue));

        while (stack.Count > 0) {
            var (node, max) = stack.Pop();

            if (node.val >= max) {
                result++;
                max = node.val;
            }

            if (node.right != null) {
                stack.Push((node.right, max));
            }

            if (node.left != null) {
                stack.Push((node.left, max));
            }
        }

        return result;
    }
}
