using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BST
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val,TreeNode left = null,TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
