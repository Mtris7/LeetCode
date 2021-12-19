using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _590
    {
        /// <summary>
        /// 590. N-ary Tree Postorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        List<int> list = new List<int>();
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
    }
}
