using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson13_Dijkstra
{
    public class _952
    {
        //https://leetcode.com/problems/largest-component-size-by-common-factor/
        Dictionary<int, int> rank;
        Dictionary<int, int> parent;

        public int LargestComponentSize(int[] nums)
        {

            parent = new Dictionary<int, int>();
            rank = new Dictionary<int, int>();

            //set default in nums
            for (int i = 0; i < nums.Length; i++)
            {
                if (!parent.ContainsKey(nums[i]))
                {

                    parent.Add(nums[i], nums[i]);
                    rank.Add(nums[i], 0);
                }
            }

            //set rank
            for (int i = 0; i < nums.Length; i++)
            {
                var hashSet = new HashSet<int>();
                hashSet = FindPrimeMethod(nums[i]);
                foreach (var item in hashSet)
                {
                    if (!rank.ContainsKey(item))
                        rank.Add(item, 0);
                    if (!parent.ContainsKey(item))
                        parent.Add(item, item);
                    union(nums[i], item);
                }
            }

            //count 
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int findParent = Find(nums[i]);
                if (!dic.ContainsKey(findParent))
                    dic.Add(findParent, 1);
                else
                    dic[findParent]++;
            }
            return dic.Values.Max();
        }
        public HashSet<int> FindPrimeMethod(int n)
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
            return hashSet;
        }
        int Find(int x)
        {
            if (parent[x] == x)
                return x;
            return Find(parent[x]);
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
                        rank[px]++;
                }
            }
        }
    }
}
