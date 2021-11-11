using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8_BFS.BFS
{
    class _433
    {
        /// <summary>
        /// 433. Minimum Genetic Mutation
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="bank"></param>
        /// <returns></returns>
        public int MinMutation(string start, string end, string[] bank)
        {
            if (bank.Length == 0) return -1;

            var bankSet = new HashSet<string>(bank);
            string GeneBase = "ACGT";
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);
            bankSet.Remove(start);
            int result = 0;
            while (queue.Any())
            {
                var currentSize = queue.Count;
                for (int i = 0; i < currentSize; i++)
                {
                    string current = queue.Dequeue();
                    if (current == end) return result;

                    foreach (char g in GeneBase)
                    {
                        var currentGene = current.ToArray();
                        for (int j = 0; j < current.Length; j++)
                        {
                            char t = currentGene[j];
                            currentGene[j] = g;
                            var next = new string(currentGene);
                            if (bankSet.Contains(next))
                            {
                                queue.Enqueue(next);
                                bankSet.Remove(next);
                            }
                            currentGene[j] = t;
                        }
                    }

                }

                result++;

            }
            return -1;
        }
    }
}
