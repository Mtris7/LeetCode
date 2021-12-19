using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _513
    {
        /// <summary>
        /// 513. Find Bottom Left Tree Value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int FindBottomLeftValue(TreeNode root)//[1,2,3,4,null,5,6,null,null,7]
        {
            int result = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                int size = queue.Count;
                bool levelChk = true;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null & levelChk)
                    {
                        result = node.left.val;
                        queue.Enqueue(node.left);
                        levelChk = false;
                    }
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return result;
        }
    }
}
