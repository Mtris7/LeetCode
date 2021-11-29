using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1627
    {
        static int[] parent;
        static int[] rank;
        public static IList<bool> AreConnected(int n, int threshold, int[][] queries)
        {
            var result = new List<bool>();
            parent = new int[n + 1];
            rank = new int[100000];
            for (int i = 1; i < n + 1; i++)
                parent[i] = i;
            foreach (var item in queries)
            {
                var hashSet = new HashSet<int>();
                hashSet = FindPrime(item[0], threshold);
                int mul = 1;
                foreach (var hash in hashSet)
                {
                    mul *= hash;
                    if (hash < threshold)
                    {
                        continue;
                    }
                    if (mul > threshold)
                        union(item[0], mul);
                    union(item[0], hash);
                }

                var hashSet2 = new HashSet<int>();
                hashSet2 = FindPrime(item[1], threshold);

                mul = 1;
                foreach (var hash in hashSet2)
                {
                    mul *= hash;
                    if (hash < threshold)
                    {
                        continue;
                    }
                    if (mul > threshold)
                        union(item[1], mul);
                    union(item[1], hash);
                }

            }

            foreach (var item in queries)
            {
                if (parent[item[0]] != parent[item[1]])
                    result.Add(false);
                else
                    result.Add(true);
            }

            return result;
        }

        static void union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);

            if (px != py)
            {
                if (rank[x] < rank[y])
                {
                    parent[x] = py;
                }
                else
                {
                    parent[y] = px;
                    if (rank[x] == rank[y])
                    {
                        rank[y]++;
                    }
                }
            }
        }

        static int Find(int x)
        {
            if (parent[x] == x)
                return x;

            return parent[x] = Find(parent[x]);
        }

        public static HashSet<int> FindPrime(int n, int threshold)
        {
            var hashSet = new HashSet<int>();
            for (int i = 2; i * i <= n; i++)
            {

                while (n % i == 0)
                {
                    hashSet.Add(i);
                    n /= i;
                }
            }
            if (n != 1)
            {
                hashSet.Add(n);
            }
            if (threshold == 0) hashSet.Add(1);
            return hashSet;
        }
    }
}
