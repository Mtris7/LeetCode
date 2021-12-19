using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _589
    {
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
