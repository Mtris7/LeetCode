using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8_BFS.BFS
{
    class _773
    {
        /// <summary>
        /// 773. Sliding Puzzle
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        HashSet<string> hashSet = new HashSet<string>();
        Queue<string> queue = new Queue<string>();

        public int SlidingPuzzle(int[][] board)
        {

            string s = "";
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[i].Length; j++)
                    s = s + board[i][j];

            queue.Enqueue(s);
            hashSet.Add(s);
            int result = 0;
            while (queue.Any())
            {
                var size = queue.Count;
                for (int k = 0; k < size; k++)
                {
                    var cur = queue.Dequeue();

                    if (cur == "123450") return result;
                    var intArr = cur.ToArray();
                    int index0 = cur.IndexOf('0');
                    if (index0 != 2)
                        isPossible(index0, index0 + 1, cur, intArr);
                    if (index0 != 3)
                        isPossible(index0, index0 - 1, cur, intArr);
                    if (index0 > 2)
                    {
                        isPossible(index0, index0 - 3, cur, intArr);
                    }
                    else
                    {
                        isPossible(index0, index0 + 3, cur, intArr);
                    }
                }

                result++;
            }
            return -1;
        }
        void isPossible(int index0, int index, string cur, char[] intArr)
        {
            if (index >= 0 && index < cur.Length)
            {
                intArr[index0] = cur[index];
                intArr[index] = cur[index0];
                var stringNext = new string(intArr);
                if (!hashSet.Contains(stringNext))
                {
                    hashSet.Add(stringNext);
                    queue.Enqueue(stringNext);
                }
                intArr[index0] = cur[index0];
                intArr[index] = cur[index];
            }
        }
    }
}
