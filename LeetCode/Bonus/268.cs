using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _268
    {
        //C1:
        public int MissingNumber(int[] nums)
        {
            var missingNumber = 0;
            for (int i = 0; i < nums.Length + 1; i++)
                missingNumber += i;
            foreach (var num in nums)
            {
                missingNumber -= num;
            }
            return missingNumber;
        }


        //C2 : use XOR
        public int MissingNumber2(int[] nums)
        {
            var missingNumber = 0;
            int i = 1;
            foreach (var num in nums)
            {
                missingNumber ^= num;
                missingNumber ^= i;
                i++;
            }
            return missingNumber;

        }
        //OR
        public int MissingNumber3(int[] nums)
        {
            return nums.Select((num, i) => num ^ i).Aggregate(nums.Length, (seed, num) => seed ^ num);
        }
    }
}
