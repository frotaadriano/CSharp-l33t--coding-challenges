using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public static class FizzBuzz
    {
        /*
        Challenge Title: FizzBuzz

        Challenge Description:
        Write a function that prints the numbers from 1 to 100. 
        But 
            for multiples of three print "Fizz" instead of the number 
            for the multiples of five print "Buzz" 
            for numbers which are multiples of both three and five print "FizzBuzz".

        Function Signature:
        public static void FizzBuzz()

         */
        public static void ShowFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        } 
    }
}
