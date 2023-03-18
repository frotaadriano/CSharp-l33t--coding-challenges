using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public static class _06___VowelCount
    {
        /*
        Challenge Title: Vowel Count

        Difficulty: Easy

        Description: Create a function that takes a string and returns the number of vowels in that string. 
        Vowels are the characters "a", "e", "i", "o", and "u".

        Example:
            VowelCount("hello world") ➞ 3
            VowelCount("the quick brown fox") ➞ 5
            VowelCount("I am groot") ➞ 3

         */
        public const string VOWELS = "aeiou";

        public static int GetVowelCount(string word)
        {
            var counter = 0;
            word = word.ToLower(); 
            foreach (var c in word)
            {
                if (VOWELS.Contains(c))
                {
                    counter++;
                }
            }             
            return counter;  
        }

    }
}
