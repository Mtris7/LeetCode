using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        List<int> list = new List<int>();
        //########################################################################################
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
        //########################################################################################
        /// <summary>
        /// 145. Binary Tree Postorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            DFSPostorderTraversal(root);
            return list;
        }

        void DFSPostorderTraversal(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null)
            {
                DFSPostorderTraversal(root.left);
            }
            if (root.right != null)
            {
                DFSPostorderTraversal(root.right);
            }
            list.Add(root.val);
        }
        //########################################################################################
        /// <summary>
        /// 590. N-ary Tree Postorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Postorder(Node root)
        {
            DFSPostorder(root);
            return list;
        }
        void DFSPostorder(Node root)
        {
            if (root == null) return;
            foreach (var item in root.children)
            {
                DFSPostorder(item);
            }
            list.Add(root.val);
        }
        //########################################################################################

        /// <summary>
        /// 94. Binary Tree Inorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            DFSInorderTraversal(root);
            return list;
        }
        void DFSInorderTraversal(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null)
            {
                DFSInorderTraversal(root.left);
            }
            list.Add(root.val);
            if (root.right != null)
            {
                DFSInorderTraversal(root.right);
            }
        }
        //########################################################################################
        /// <summary>
        /// 144. Binary Tree Preorder Traversal
        /// </summary>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            DFSPreorderTraversal(root);
            return list;
        }
        void DFSPreorderTraversal(TreeNode root)
        {
            if (root == null) return;
            list.Add(root.val);
            if (root.left != null)
            {
                DFSPreorderTraversal(root.left);
            }
            if (root.right != null)
            {
                DFSPreorderTraversal(root.right);
            }
        }
        //########################################################################################
        /// <summary>
        /// 1372. Longest ZigZag Path in a Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        int max = 0;
        public int LongestZigZag(TreeNode root)
        {
            DFSZigZag(root, 'o', 0);
            return max;
        }
        void DFSZigZag(TreeNode root, char direction, int len)
        {
            if (root.left != null && (direction == 'r' || direction == 'o'))
            {
                DFSZigZag(root.left, 'l', len + 1);
            }
            if (root.left != null && direction == 'l')
            {
                max = Math.Max(max, len);
                DFSZigZag(root.left, 'l', 1);
            }
            if (root.right != null && (direction == 'l' || direction == 'o'))
                DFSZigZag(root.right, 'r', len + 1);

            if (root.right != null && direction == 'r')
            {
                max = Math.Max(max, len);
                DFSZigZag(root.right, 'r', 1);
            }
            if (root.left == null && root.right == null)
                max = Math.Max(max, len);

        }
        //########################################################################################
        /// <summary>
        /// 687. Longest Univalue Path
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        Stack<int> stack = new Stack<int>();
        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null) return 0;

            stack.Push(root.val);
            DFS(root);
            LongestUnivaluePath(root.left);
            LongestUnivaluePath(root.right);
            return max;
        }
        int DFS(TreeNode root)
        {
            if (root == null || root.val != stack.Peek()) return 0;

            int lMax = DFS(root.left);
            int rMax = DFS(root.right);

            max = Math.Max(lMax + rMax, max);

            return Math.Max(lMax, rMax) + 1;

        }
        //########################################################################################
        /// <summary>
        /// 543. Diameter of Binary Tree
        /// </summary>
        private static int res = 0;
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            DFSMaxLength(root);

            return res;
        }
        static int DFSMaxLength(TreeNode root)
        {
            if (root == null) return 0;

            int lMax = DFSMaxLength(root.left);
            int rMax = DFSMaxLength(root.right);

            res = Math.Max(lMax + rMax, res);

            return Math.Max(lMax, rMax) + 1;
        }
        //########################################################################################
        /// <summary>
        /// 104. Maximum Depth of Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null)
                return MaxDepth(root.right) + 1;
            else if (root.right == null)
                return MaxDepth(root.left) + 1;
            else
                return Math.Max(MaxDepth(root.right), MaxDepth(root.left)) + 1;
        }
        //########################################################################################
        /// <summary>
        /// 111. Minimum Depth of Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null)
                return MinDepth(root.right) + 1;
            else if (root.right == null)
                return MinDepth(root.left) + 1;
            else
                return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
        //########################################################################################
        /// <summary>
        /// 404. Sum of Left Leaves
        /// </summary>
        int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root.left == null && root.right == null) return 0;
            DFS(root.left, true);
            DFS(root.right, false);
            return sum;
        }
        private void DFS(TreeNode root, bool checkLeft)
        {
            if (root == null) return;
            if (checkLeft && root.left == null && root.right == null)
                sum += root.val;

            DFS(root.left, true);
            DFS(root.right, false);
        }
    }
}
