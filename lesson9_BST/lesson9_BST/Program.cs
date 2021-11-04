using System;

namespace lesson9_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            //701. Insert into a Binary Search Tree
            //700. Search in a Binary Search Tree

            var root = new TreeNode(5);//5,3,6,2,4,null,7
            var cur = root;
            cur.left = new TreeNode(3);
            cur.right = new TreeNode(6);
            cur = cur.left;
            cur.left = new TreeNode(2);
            cur.right = new TreeNode(4);
            cur = root.right;
            cur.right = new TreeNode(7);
            bool[,] visited = new bool[2, 8];
            //DeleteNode(root, 3);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 8; j++)
                    Console.WriteLine(visited[i,j]);
            Console.WriteLine("Hello World!");
            //closest-binary-search-tree-value
        }
        //#######################################################################################################################
        //#######################################################################################################################
        /// <summary>
        /// 450. Delete Node in a BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            if (root.val < key)
                root.right = DeleteNode(root.right, key);
            else if (root.val > key)
                root.left = DeleteNode(root.left, key);
            else
            {
                if (root.right == null)
                    return root.left;
                else if (root.left == null)
                    return root.right;

                var minNode = FindMinNode(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, root.val);
            }
            return root;
        }

        public TreeNode FindMinNode(TreeNode root)
        {
            while (root.left != null)
                root = root.left;
            return root;
        }
        //#######################################################################################################################
        /// <summary>
        /// 700. Search in a Binary Search Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;
            else if (root.val > val) return SearchBST(root.left, val);
            else return SearchBST(root.right, val);
        }
        //#######################################################################################################################
        /// <summary>
        /// 701. Insert into a Binary Search Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);
            if (root.val > val) root.left = InsertIntoBST(root.left, val);
            else root.right = InsertIntoBST(root.right, val);
            return root;
        }
        //#######################################################################################################################
    }
}
