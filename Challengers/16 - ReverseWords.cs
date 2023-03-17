using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    public class ReverseWords
    {
        /// <summary>
        /// Challenge name: Reverse Words
        /// Difficulty level: Easy
        /// Description: Write a function that takes a string of words and returns a new string with the
        ///              words reversed, but the order of the words unchanged.You can assume that the input string 
        ///              contains only letters and spaces, and that there is exactly one space between each pair of
        ///              words.For example, if the input string is "hello world", 
        ///              the function should return "olleh dlrow".
        /// Example:
        /// Input: "hello world"
        /// Output: "olleh dlrow"
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string  GenerateReverseWords(string words)
        {
            var reversed = "";

            for (int i = words.Length-1; i >= 0; i--)
            {
                reversed = reversed + words[i];
            }
            return reversed;
        }

        public static string ReverseStringOptmized(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
