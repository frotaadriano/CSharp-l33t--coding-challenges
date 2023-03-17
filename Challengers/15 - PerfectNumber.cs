using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public class PerfectNumber
    {
        /*
        Challenge Name: Perfect Number
        Difficulty Level: Easy
        Description: A perfect number is a positive integer that is equal to the sum of its proper positive 
        divisors, excluding the number itself. Write a function to determine if a given positive integer is a
        perfect number or not.

        Example:

        Input: 6
        Output: true (6 is a perfect number because 1+2+3 = 6)
        Input: 28
        Output: true (28 is a perfect number because 1+2+4+7+14 = 28)
        Input: 10
        Output: false (10 is not a perfect number because 1+2+5 != 10)
        */
        public static string IsPerfectNumber(int number)
        {
            if(number < 2)
            {
                return $"{number} isn't a Perfect Number";
            }

            var sum = 1;
            var halfOfNumber = number / 2;

            for (int i = 2; i <= halfOfNumber; i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number ? $"{number} is a Perfect Number" : $"{number} isn't a Perfect Number"; 
        }
    }
}
