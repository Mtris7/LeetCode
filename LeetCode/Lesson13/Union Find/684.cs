using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson13.Union_Find
{
    class _684
    {
        //https://leetcode.com/problems/redundant-connection/
        int[] parent;
        int[] rank;
        public int[] FindRedundantConnection(int[][] edges)
        {
            parent = new int[edges.Length + 1];
            rank = new int[edges.Length + 1];

            for (int i = 1; i <= edges.Length; i++)
                parent[i] = i;

            foreach (var item in edges)
            {
                if (Find(item[0]) == Find(item[1])) return item;
                union(item[0], item[1]);
            }
            return null;
        }
        int Find(int x)
        {
            if (parent[x] == x)
                return x;
            else return parent[x] = Find(parent[x]);
        }
        void union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);
            if (px != py)
            {
                if (rank[px] > rank[py])
                {
                    parent[py] = px;
                }
                else
                {
                    parent[px] = py;
                    if (rank[px] == rank[py])
                        rank[py]++;
                }
            }
        }
    }
}
