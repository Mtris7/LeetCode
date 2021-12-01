using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _285
    {
        //https://leetcode.com/problems/inorder-successor-in-bst/
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode result = null;
            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (node.val <= p.val)
                {
                    if (node.right != null) queue.Enqueue(node.right);
                }
                else
                {
                    if ((result == null && node.val != p.val) || (result != null && result.val > node.val))
                        result = node;
                    if (node.left != null && node.val > p.val) queue.Enqueue(node.left);
                }
            }
            return result;

        }
    }
}
