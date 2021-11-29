using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _990
    {
        //https://leetcode.com/problems/satisfiability-of-equality-equations/

        int[] parent = new int[26];

        int[] rank = new int[26];
        public bool EquationsPossible(string[] equations)
        {

            for (int i = 0; i < 26; i++)
            {
                parent[i] = i;
            }
            foreach (var eq in equations)
            {
                if (eq[1] == '=')
                {
                    Union(eq[0] - 'a', eq[3] - 'a');
                }
            }
            foreach (var eq in equations)
            {
                if (eq[1] == '!')
                {
                    if (Find(eq[0] - 'a') == Find(eq[3] - 'a'))
                        return false;
                }
            }
            return true;
        }

        int Find(int x)
        {
            if (parent[x] == x)
                return x;
            else
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        void Union(int x, int y)
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
