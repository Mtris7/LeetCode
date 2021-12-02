using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _127
    {
        /// <summary>
        /// 127. Word Ladder
        /// </summary>
        /// <param name="beginWord"></param>
        /// <param name="endWord"></param>
        /// <param name="wordList"></param>
        /// <returns></returns>
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord))
                return 0;

            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            var result = 1;

            while (queue.Any())
            {
                var queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++) // size queue
                {
                    var current = queue.Dequeue();
                    wordSet.Remove(current);
                    var wordArray = current.ToArray();

                    for (int m = 0; m < current.Length; m++)// m => length
                    {
                        var curChar = current[m];
                        for (char n = 'a'; n <= 'z'; n++)//24
                        {
                            if (wordArray[m] != n)
                            {
                                wordArray[m] = n;
                                var nextWord = new string(wordArray);

                                if (nextWord == endWord)
                                    return result + 1;

                                if (wordSet.Contains(nextWord))
                                {
                                    queue.Enqueue(nextWord);
                                    wordSet.Remove(nextWord);
                                }
                            }
                            wordArray[m] = curChar;
                        }
                    }

                }
                result++;
            }
            return 0;
        }
    }
}
