using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson15.MST
{
    class _1135
    {
        //https://leetcode.com/problems/connecting-cities-with-minimum-cost/
        int[] parent;
        int[] rank;
        public int MinimumCost(int n, int[][] connections)
        {
            parent = new int[n + 1];
            rank = new int[n + 1];
            for (int i = 0; i <= n; i++)
                parent[i] = i;

            Array.Sort(connections, (a, b) => a[2].CompareTo(b[2]));

            int result = 0;
            foreach (var connection in connections)
            {
                if (Find(connection[0]) != Find(connection[1]))
                {
                    result += connection[2];
                    union(connection[0], connection[1]);
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (Find(i) != Find(1))
                    return -1;
            }

            return result;

        }
        int Find(int x)
        {
            if (parent[x] == x)
                return x;
            else
                return parent[x] = Find(parent[x]);
        }
        void union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);
            if (px != py)
            {
                if (rank[px] > rank[py])
                    parent[py] = px;
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
