using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _337
    {
        //337. House Robber III
        /*
         * The thief has found himself a new place for his thievery again. There is only one entrance to this area, called root.

        Besides the root, each house has one and only one parent house. After a tour, the smart thief realized that all houses in this place form a binary tree. It will automatically contact the police if two directly-linked houses were broken into on the same night.

        Given the root of the binary tree, return the maximum amount of money the thief can rob without alerting the police.
         */
        /// <summary>
        /// 337. House Robber III
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Rob(TreeNode root)
        {
            var dic = new Dictionary<(TreeNode, bool), int>();
            DFSRob(root, dic);
            return Math.Max(dic[(root, true)], dic[(root, false)]);
        }
        void DFSRob(TreeNode root, Dictionary<(TreeNode, bool), int> dic)
        {
            if (root == null)
            {
                dic[(root, true)] = 0;
                dic[(root, false)] = 0;
                return;
            };

            DFSRob(root.left, dic);
            DFSRob(root.right, dic);

            dic[(root, true)] = dic[(root.left, false)] + dic[(root.right, false)] + root.val;

            int c1 = dic[(root.left, true)] + dic[(root.right, true)];
            int c2 = dic[(root.left, false)] + dic[(root.right, false)];
            int c3 = dic[(root.left, true)] + dic[(root.right, false)];
            int c4 = dic[(root.left, false)] + dic[(root.right, true)];

            dic[(root, false)] = Math.Max(Math.Max(c1, c2), Math.Max(c3, c4));
        }
    }
}
