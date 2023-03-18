using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    public class Fibonacci
    {
        /// <summary>
        /// Challenge Name: Fibonacci Sequence
        /// Difficult Level: Easy
        /// Description: Write a function that takes an integer n and returns the nth number in the Fibonacci sequence.
        /// The Fibonacci sequence is a series of numbers in which each number after the first two is the sum of the two 
        /// preceding ones.For example, the first ten Fibonacci numbers are: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.
        ///
        /// Example:
        /// Input: 6
        /// Output: 8
        /// Explanation: The 6th number in the Fibonacci sequence is 8, which is the sum of the 4th and 5th numbers: 3 + 5 = 8.
        /// </summary>
        /// <param name="seqPosition"></param>
        /// <returns></returns>
        public static int GetFiboInSequence(int seqPosition)
        {
            if (seqPosition <= 1)
            {
                return seqPosition;
            }

            int prev = 0, curr = 1;
            for (int i = 2; i <= seqPosition; i++)
            {
                int temp = curr;
                curr += prev;
                prev = temp;
            }

            return curr;
        }
    }
}
