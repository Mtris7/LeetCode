using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _240
    {
        /// <summary>
        /// 240. Search a 2D Matrix II
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int i = matrix.Length - 1;
            int j = 0;
            while (i >= 0 && j < matrix[0].Length)
            {
                if (matrix[i][j] == target) return true;
                else if (matrix[i][j] > target) i--;
                else j++;
            }
            return false;
        }
    }
}
