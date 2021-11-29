using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    class _922
    {
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
    }
}
