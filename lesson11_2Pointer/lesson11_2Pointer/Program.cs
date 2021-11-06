using System;

namespace lesson11_2Pointer
{
    class Program
    {
        static void Main(string[] args)
        {


            //167.Two Sum II -Input Array Is Sorted
            // 485. Max Consecutive Ones
            // 26. Remove Duplicates from Sorted Array
            //845.Longest Mountain in Array
            Console.WriteLine("Hello World!");
        }
        //##########################################################################################################################
        //##########################################################################################################################
        //##########################################################################################################################
        //##########################################################################################################################
        //##########################################################################################################################\
        /// <summary>
        /// 167. Two Sum II - Input Array Is Sorted
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            /*
             * C1: use space : 
             * 
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsValue(target - numbers[i]))
                {
                    return new int[] { dic.First(x=>x.Value == (target - numbers[i])).Key, i + 1 };
                }
                else
                    dic.Add( i + 1,numbers[i]);

            }
            return new int[] { };*/
            int i = 0;
            int j = numbers.Length - 1;
            while (i < j)
            {
                if (numbers[i] + numbers[j] == target) return new int[] { i + 1, j + 1 };
                else if (numbers[i] + numbers[j] > target) j--;
                else i++;
            }
            return new int[] { };
        }
        //##########################################################################################################################
        /// <summary>
        /// 485. Max Consecutive Ones
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) count++;
                result = Math.Max(result, count);
                if (nums[i] == 0)
                {
                    count = 0;
                }
            }
            return result;
        }
        //##########################################################################################################################
        /// <summary>
        /// 26. Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int left = 1;
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    nums[left] = nums[i];
                    count++;
                    left++;
                }
            }
            return count;
        }
        //##########################################################################################################################
        /// <summary>
        /// 845. Longest Mountain in Array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int LongestMountain(int[] arr)
        {
            int result = 0;
            int i = 0;
            while (i < arr.Length)
            {
                int j = i;
                while (j + 1 < arr.Length && arr[j] < arr[j + 1])
                {
                    j++;
                }
                int k = j;
                while (k + 1 < arr.Length && arr[k] > arr[k + 1]) k++;

                if (k != j && i != j) result = Math.Max(result, k - i + 1);

                if (k != i) i = k;
                else i++;
            }
            return result;
        }
    }
}
