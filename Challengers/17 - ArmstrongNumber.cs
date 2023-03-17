using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Math;

namespace Challengers
{
    public class ArmstrongNumber
    {
        /// <summary>
        ///  Challenge name: Armstrong Number Checker
        ///  Difficult level: Easy
        ///  Description: An Armstrong number is a number that is equal to the sum of its own digits each raised to the power of 
        ///  the number of digits.For example, 153 is an Armstrong number, because 1^3 + 5^3 + 3^3 = 153. Write a function that 
        ///  1+125+27
        ///  takes an integer as input and returns "Armstrong Number" if the number is an Armstrong number, or "Not Armstrong Number"
        ///  if it is not.
        /// 
        ///  Example:
        ///  Input: 153
        ///  Output: "Armstrong Number" 
        ///  
        ///  Input: 9474
        ///  Output: "Armstrong Number" 
        /// 
        ///  Input: 123
        ///  Output: "Not Armstrong Number"
        /// 
        /// </summary>
        public static string IsArmstrongNumber(string number)
        {
            int i = 0;
            bool result = int.TryParse(number, out i);
            var exponent = number.Length;
            var sum = 0.0;
            var Noo = $"[== Nooo! ==] {number} isn't an Armstrong Number";

            if (string.IsNullOrEmpty(number) || !result || Convert.ToInt32(number) < 1)
            {
                return "Number Invalid or Empty";
            }
            foreach (var c in number)
            {
                sum += Pow(Convert.ToDouble(c.ToString()), exponent);

                if (sum > i) return Noo;
            }

            return sum == i ? $"[ == Yes! ==] {number} is an Armstrong Number" : Noo;
        }

        public static string IsArmstrongNumberOptmized(int number)
        {
            var Noo = $"[== Nooo! ==] {number} isn't an Armstrong Number";
            int sum = 0;
            int temp = number;
            double log10 = Math.Log10(number);
            int digits = (int)Math.Floor(log10 + 1);

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }
            return sum == number ? $"[ == Yes! ==] {number} is an Armstrong Number" : Noo;

        }

    }
}
