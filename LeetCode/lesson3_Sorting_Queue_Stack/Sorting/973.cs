using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode_L3.Sorting
{
    class _973
    {
        public int[][] KClosest(int[][] points, int k)
        => points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(k).ToArray();
    }
}
