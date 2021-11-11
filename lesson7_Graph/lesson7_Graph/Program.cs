using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson7_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sub   https://leetcode.com/.../number-of-connected-components.../
            //547   https://leetcode.com/problems/number-of-provinces/
            //841   https://leetcode.com/problems/keys-and-rooms/
            //200   https://leetcode.com/problems/number-of-islands/
            //695   https://leetcode.com/problems/max-area-of-island/
            //404   https://leetcode.com/problems/sum-of-left-leaves/
            //111   https://leetcode.com/problems/minimum-depth-of-binary-tree/
            //104   https://leetcode.com/problems/maximum-depth-of-binary-tree/
            //543   https://leetcode.com/problems/diameter-of-binary-tree/ 
            //508   https://leetcode.com/problems/most-frequent-subtree-sum/ unfinish
            //Sub   https://leetcode.com/problems/diameter-of-n-ary-tree/
            //687   https://leetcode.com/problems/longest-univalue-path/
            //1372  https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree/
            //337   https://leetcode.com/problems/house-robber-iii/
            //144   https://leetcode.com/problems/binary-tree-preorder-traversal/
            //94    https://leetcode.com/problems/binary-tree-inorder-traversal/
            //145   https://leetcode.com/problems/binary-tree-postorder-traversal/
            //590   https://leetcode.com/problems/n-ary-tree-postorder-traversal/
        }

        //###########################################################################################################
        /// <summary>
        /// 124. Binary Tree Maximum Path Sum
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxPathSum(TreeNode root)
        {
            //queue.Enqueue(root);
            int result = int.MinValue;
            int maxL = int.MinValue;
            int maxR = int.MinValue;

            if (root.left != null) maxL = DFS(root.left) + root.val;
            if (root.right != null) maxR = DFS(root.right) + root.val;
            result = Math.Max(root.val, maxL - root.val);
            result = Math.Max(result, maxR - root.val);
            result = Math.Max(result, maxL);
            result = Math.Max(result, maxR);
            result = Math.Max(result, maxL + maxR - root.val);
            result = Math.Max(result, sumChild);
            return result;
        }
        static int sumChild = int.MinValue;
        static int DFS(TreeNode root)
        {
            if (root.left == null && root.right == null) return root.val;
            int res = int.MinValue;
            int maxL = int.MinValue;
            int maxR = int.MinValue;
            if (root.left != null) maxL = DFS(root.left) + root.val;
            if (root.right != null) maxR = DFS(root.right) + root.val;

            res = Math.Max(root.val, maxL);// root vs left vs right vs root + left vs root + right 
            res = Math.Max(res, maxR);
            sumChild = Math.Max(res, maxL + maxR - root.val);
            return res;
        }
        //###########################################################################################################
        //589. N-ary Tree Preorder Traversal
        List<int> list = new List<int>();
        public IList<int> Preorder(Node root)
        {
            DFS(root);
            return list;
        }
        void DFS(Node root)
        {
            if (root == null) return;
            list.Add(root.val);
            foreach (var item in root.children)
            {
                if (item.children != null)
                    DFS(item);

                else list.Add(item.val);
            }
        }

    }

}
