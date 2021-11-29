using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _781
    {
        //781. Rabbits in Forest
        public int NumRabbits(int[] answers)
        {
            /* create hashtable to save key is value of array and value is a number of occurrences (1 : default)
             * loop : from i to n  : compare value of array and key : if exist :  increase value by 1 
             *  second compare : value in hashtable and value of array + 1 => if hashtable[value] > array[value] => remove hashtable
             *  because : we have enough of the rappit with same color : 
             *  example : [0,0,1,1,1] : rabbit at index 0 : it not have any rabbit has color like it : so we need to remove value of hashtable
             */
            var dic = new Dictionary<int, int>();
            int you = 1;
            int sum = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (!dic.ContainsKey(answers[i]))
                {
                    dic.Add(answers[i], 1);
                    sum += answers[i] + you;
                }
                else
                    dic[answers[i]]++;
                if (dic[answers[i]] >= you + answers[i])
                    dic.Remove(answers[i]);


            }
            return sum;

        }
    }
}
