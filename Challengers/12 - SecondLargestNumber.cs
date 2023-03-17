using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public static class SecondLargestNumber
    {

        /*
            Challenge name: Find the Second Largest Number
            Difficulty level: Easy

            Description: Write a C# function that takes an array of integers as input and 
            returns the second largest number in the array. If the array contains only one number, 
            the function should return that number.

            Example:
            Input: [3, 1, 5, 7, 4, 8]
            Output: 7

            Input: [10, 5, 10]
            Output: 5

            Input: [1]
            Output: 1
         */
        public static int Get(int[] ints)
        {
            Array.Sort(ints);

            var max = 0;
            var secoundMax = 0;

            foreach (int i in ints)
            {
                if(i > max)
                {
                    secoundMax = max;
                    max = i;
                }
            }

            return secoundMax;
        }
    }
}
