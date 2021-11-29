using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumMatrix
    {
        private int[][] _matrix;
        public NumMatrix(int[][] matrix)
        {
            _matrix = matrix;
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 1; j < matrix[i].Length; j++)
                    _matrix[i][j] += _matrix[i][j - 1];
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int sum = 0;
            for (; row1 <= row2; row1++)
            {
                if (col1 == 0)
                    sum += _matrix[row1][col2];
                else
                    sum += _matrix[row1][col2] - _matrix[row1][col1 - 1];
            }

            return sum;
        }
    }
}
