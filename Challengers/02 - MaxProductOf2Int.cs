using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    /*
    maximum product of any two
    Problem Statement
    You are given a non-empty array of integers nums. Your task is to find the maximum product of any two distinct elements in the array.

    Write a function maxProduct(int[] nums) that takes an integer array nums as input, and returns the maximum product of any two distinct elements in the array.

    Example 
    maxProduct([1, 2, 3, 4, 5]) => 20

    */

    /// <summary>
    /// Solution 1 - Not optmized
    /// </summary>
    public static class MaxProductOf2Int
    {
        public static int MaxProduct(int[] numbers)
        {
            var max = numbers.Max(x => x);

            var secoundMax = numbers.Except(new int[] { max }).Max();

            return max * secoundMax;
        }

        /// <summary>
        /// First Optimized solution
        /// </summary>
        public static int MinProductOf2IntOptimized_1(int[] nums)
        {
            int max1 = 0, max2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max1)
                {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max2 = nums[i];
                }
            }
            return max1 * max2;
        }
    }
}
