using System;

namespace lesson9_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            //701   https://leetcode.com/problems/insert-into-a-binary-search-tree/
            //700   https://leetcode.com/problems/search-in-a-binary-search-tree/
            //450   https://leetcode.com/problems/delete-node-in-a-bst/
            //[3,1,4,null,2], k = 1
            //8,5,10,2,7,null,null,1
            TreeNode root = new TreeNode(8);
            root.left = new TreeNode(5);
            root.right = new TreeNode(10);
            var cur = root.left;
            cur.left = new TreeNode(2);
            cur.right = new TreeNode(7);
             cur = cur.left;
            cur.left = new TreeNode(1);
            //_230.KthSmallest(root, 6);
            Console.WriteLine("Hello World!");
        }
    }
}
