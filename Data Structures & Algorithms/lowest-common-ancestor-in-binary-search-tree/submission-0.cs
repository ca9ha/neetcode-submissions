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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) {
            return null;
        }

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        var min = Math.Min(p.val, q.val);
        var max = Math.Max(p.val, q.val);

        while (stack.Count > 0) {
            var node = stack.Pop();
            if (min <= node.val && max >= node.val) {
                return node;
            }

            if(max <= node.val) // 2 numbers less then node
            {
                stack.Push(node.left);
            }

            if(min >= node.val)
            {
                 stack.Push(node.right);
            }
           
        }

         return null;
    }
}
