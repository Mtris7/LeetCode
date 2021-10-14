using System;

namespace LeetCode_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int SubarraySum(int[] nums, int k)
        {
            /*
             * i have a worst solution: 
             * create sum and count  = 0;
             * we have two loop and check from 0 in array -> n : count the number of the time sum = k 
             * time O(n)
             * space O(1)
             * because value in nums has a negative, so i don't have bester solution
             * do you want to me improve solution or implementation
             */
            int sum = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = nums[i];
                if (sum == k) count++;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        /*
         * i have a worst solution to create two loop and check and count max sum like it
         * [-2,1,-3,4,-1,2,1,-5,4] i = -2 => j = i+ 1 = 1 run to the end of number and check sum 
         * but i think.. i have a bester solution
         * just one loop and create max and sum and we need to check total i and previous i
         * example [-2,1,-3,4,-1,2,1,-5,4]  
         * if i = 1 , we compare nums[1] vs sum[-2,1] => we choose num[1] because num[1] > sum 
         * and we compare sum with max =>> max = sum in this case
         * do you understand my solution? and do you want to me inprove my solution or implementation?
         *                                          
         */
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length < 2) return nums[nums.Length - 1];

            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < nums[i])
                    sum = nums[i];
                if (sum > max)
                    max = sum;
            }
            return max;
        }
    }
    
}
