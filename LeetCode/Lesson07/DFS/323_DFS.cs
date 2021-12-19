using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson7.DFS
{
    class _323_DFS
    {
        bool[] visited;
        List<int>[] node;
        public int CountComponents(int n, int[][] edges)
        {

            visited = new bool[n];
            node = new List<int>[n];
            foreach (var item in edges)
            {
                if (node[item[0]] == null)
                    node[item[0]] = new List<int>();

                node[item[0]].Add(item[1]);


                if (node[item[1]] == null)
                    node[item[1]] = new List<int>();

                node[item[1]].Add(item[0]);
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    count++;
                    DFS(i);
                }
            }
            return count;

        }
        void DFS(int i)
        {
            if (visited[i]) return;

            if (node[i] == null) return;

            foreach (var item in node[i])
            {
                visited[i] = true;
                DFS(item);
            }
        }
    }
}
