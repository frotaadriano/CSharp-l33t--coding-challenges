using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    public static class SumOfPrimes
    {
        /*
        Challenge: Sum of Primes

        Write a function that accepts a positive integer n and returns the sum of all prime numbers that are less than or equal to n.

        Function signature: public static int SumOfPrimes(int n)

        Example:

        Input: n = 10

        Output: 17

        Explanation: The prime numbers less than or equal to 10 are 2, 3, 5, and 7. Their sum is 2 + 3 + 5 + 7 = 17.
         */
        public static object GetResult(int n)
        {
            if (n < 2) // 0 and 1 are not considered prime numbers
            {
                return 0;
            }

            int sum = 2; // initialize sum to 2, the first prime number
            for (int i = 3; i <= n; i += 2) // start from 3 and increment by 2 to consider only odd numbers
            {
                bool isPrime = true;
                int limit = (int)Math.Sqrt(i); // the largest factor of a number can be at most its square root

                for (int j = 3; j <= limit; j += 2) // check all odd numbers as potential factors
                {
                    if (i % j == 0) // if i is divisible by j, it's not a prime number
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) // if i is a prime number, add it to the sum
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
