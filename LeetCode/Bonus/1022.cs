using System;

namespace LeetCode
{
    public class _1022
    {
        private int res = 0;
        public int SumRootToLeaf(TreeNode root)
        {
            DFS(root, root.val);
            return res;
        }
        public void DFS(TreeNode root, int curValue)
        {
            if (root.left == null && root.right == null)
                res += curValue;

            if (root.left != null)
            {
                DFS(root.left, 2 * curValue + root.left.val);
            }
            if (root.right != null)
            {
                DFS(root.right, 2 * curValue + root.right.val);
            }
        }
        public void DFS2(TreeNode root, string str)
        {
            if (root.left == null && root.right == null)
            {
                str += root.val;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '0') continue;

                    res += (int)Math.Pow(2, str.Length - i - 1);
                }
            }
            if (root.left != null)
                DFS2(root.left, str + "" + root.val);
            if (root.right != null)
                DFS2(root.right, str + "" + root.val);


        }
    }
}
