using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,3,4 };
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        
        //running-sum-of-1d-array
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }

        //move-zeroes
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }
        }

        ///sort-colors
        public void SortColors(int[] nums)
        {
            int pivot = 1;
            int boundary = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    int temp = nums[i];
                    nums[i] = nums[boundary];
                    nums[boundary] = temp;
                    boundary++;
                }
            }
            boundary = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] > pivot)
                {
                    int temp = nums[i];
                    nums[i] = nums[boundary];
                    nums[boundary] = temp;
                    boundary--;
                }
            }
        }

        //sort-array-by-parity
        public int[] SortArrayByParity(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    for (int j = nums.Length - 1; j > i; j--)
                    {
                        if (nums[j] % 2 == 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }
            return nums;
        }

        //sort-array-by-parity-ii
        public int[] SortArrayByParityII(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && i % 2 != 0)
                {
                    for (int j = nums.Length - 1; j > i; j--)
                    {
                        if (nums[j] % 2 != 0 && j % 2 == 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }

                if (nums[i] % 2 != 0 && i % 2 == 0)
                {
                    for (int j = nums.Length - 1; j > i; j--)
                    {
                        if (nums[j] % 2 == 0 && j % 2 != 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }
            return nums;
        }

        //power-of-two
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && ((n & (n - 1)) == 0);
        }

        //number-of-1-bits
        public int HammingWeight(uint n)
        {
            if (n == 0) return 0;
            int i = 1;
            uint check = n & (n - 1);
            while (check != 0)
            {
                check = check & (check - 1);
                i++;
            }
            return i;
        }

        //happy-number
        public bool IsHappy(int n)
        {
            //25 4+25=29 4+91 = 85 ;64+25=89;64+81=145 ;1+16+25=42;20;4
            //18 1+64=65;36"+25=61;36+1=37;9+49 58;25 64 89;64 81 145;1 16 25 42;16 4 20;4;
            //17 1 49 50 ; 25;4 25 29;4 81 85; 64 25 89;64 81 145
            int result = 0;
            while (result != 1 && result != 4)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += (n % 10) * (n % 10);
                    n = n / 10;
                }
                n = sum;
                result = sum;
            }

            if (result == 1) return true;

            return false;
        }

        //subsets
        public IList<IList<int>> Subsets(int[] nums)
        {
            int n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>());
            for (int i = 1; i < Math.Pow(2, n); i++)
            {
                IList<int> list = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (GetBit(i, j))
                        list.Add(nums[j]);
                }
                result.Add(list);
            }
            return result;
        }
        public bool GetBit(int i, int j)
        {
            return ((i >> j) & 1) == 1;
        }
    }
}
