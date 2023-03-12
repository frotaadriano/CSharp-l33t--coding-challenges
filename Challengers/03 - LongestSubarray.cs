using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    public class LongestSubarray
    {

        /// <summary>
        /// 
        /// "Summit Seeker: Conquering the Longest Subarray"
        /// 
        /// Given an array of integers, write a function to find the longest subarray with a sum that equals a given target value. If there are multiple subarrays with the same length, return the one that starts at the earliest index.
        ///
        /// For example, given the array[1, 2, 3, 4, 5] and the target value 9, the function should 
        /// return [2, 3, 4], since this subarray has a sum of 9 and is the longest subarray with 
        /// this sum.If there are no subarrays with the given sum, the function should return an 
        /// empty array.
        /// Your function should take the following signature:            
        /// 
        ///   public static int[] FindLongestSubarrayWithSum(int[] nums, int target)
        ///   
        /// Constraints:
        ///   The input array may contain negative integers.
        ///   The length of the input array is at most 10,000.
        ///   The target value is an integer.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] FindLongestSubarrayWithSum(int[] nums, int target)
        {
            Array.Sort(nums);
            var sum = 0;
            int[] subArray = new int[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (sum + nums[i] > target)
                {
                    return subArray;
                }
                else
                {
                    sum += nums[i];
                    Array.Resize(ref subArray, subArray.Length + 1);
                    subArray[subArray.Length - 1] = nums[i];
                }
            }
            return subArray;
        }
        public static int[] FindLongestSubarrayWithSum_optimized_1(int[] nums, int target)
        {
            int left = 0, right = 0, sum = 0, maxLength = 0, maxLeft = 0;

            while (right < nums.Length)
            {
                sum += nums[right];
                right++;

                while (sum > target && left < right)
                {
                    sum -= nums[left];
                    left++;
                }

                int length = right - left;
                if (length > maxLength)
                {
                    maxLength = length;
                    maxLeft = left;
                }
            }

            return nums.Skip(maxLeft).Take(maxLength).ToArray();
        }
    }
}
