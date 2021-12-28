using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _108
    {
        //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return DFS(nums, 0, nums.Length - 1);
        }
        public TreeNode DFS(int[] nums, int l, int r)
        {
            if (l > r) return null;
            int mid = (r + l) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = DFS(nums, l, mid - 1);
            root.right = DFS(nums, mid + 1, r);
            return root;
        }
    }
}
