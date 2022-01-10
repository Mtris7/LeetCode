using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _235
    {
        //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val <= root.val && q.val >= root.val || (p.val >= root.val && q.val <= root.val))
                return root;
            else if (p.val > root.val && q.val > root.val)
                return LowestCommonAncestor(root.right, p, q);
            else return LowestCommonAncestor(root.left, p, q);
        }
    }
}
