using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson05.Hash
{
    class _36
    {
        public bool IsValidSudoku(char[][] board)
        {
            var col = new HashSet<char>[9];
            var row = new HashSet<char>[9];
            var box = new HashSet<char>[9];
            for (int i = 0; i < 9; i++)
            {
                col[i] = new HashSet<char>();
                row[i] = new HashSet<char>();
                box[i] = new HashSet<char>();
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (col[i].Contains(board[i][j]) || row[j].Contains(board[i][j]))
                            return false;
                        else
                        {
                            col[i].Add(board[i][j]);
                            row[j].Add(board[i][j]);
                        }
                    }
                }
            }
            /*
                box1 :  0 -> 2
                        0 -> 2
                box2 :  3->5
                        0 -> 2
                box2 :  6->8
                        0 -> 2

            */

            for (int i = 0; i < 9; i++)
            {
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        int rr = r + 3 * (i / 3);
                        int cc = c + 3 * (i % 3);
                        if (board[rr][cc] != '.')
                        {
                            if (box[i].Contains(board[rr][cc]))
                                return false;
                            else
                            {
                                box[i].Add(board[rr][cc]);
                            }
                        }
                    }
                }
            }
            return true;

        }
    }
}
