using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public class _05____PalindromePermutation
    {
        /*
        Challenge Title: "The Palindrome Permutation"

        Challenge Description:
        Write a function that takes a string as input and returns true if the string can be rearranged into a palindrome, false otherwise. A palindrome is a word or phrase that reads the same backward as forward. A permutation is a rearrangement of letters. The palindrome does not need to be limited to just dictionary words.

        Example 1:
        Input: "racecar"
        Output: true

        Example 2:
        Input: "tactcoa"
        Output: true (permutations: "tacocat", "atcocta", etc.)

        Example 3:
        Input: "hello"
        Output: false

        Constraints:

        The input string consists of lowercase letters only.
         */

        //First approach but wrong. Need to check if I can transform a word into a Palindrome
        public static bool GetPalindromePermutation(string word)
        {
            var inverted = "";

            for (int i = word.Length-1; i >= 0; i--)
            {
                inverted += word[i];
            }
            return inverted.ToLower() == word.ToLower();
        }


        //Opt and right answer
        public static bool IsPalindromePermutation(string str)
        {
            // Remove whitespace and convert to lowercase
            str = new string(str.Where(c => !char.IsWhiteSpace(c)).Select(c => char.ToLower(c)).ToArray());

            // Count the frequency of each character
            var charFreq = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charFreq.ContainsKey(c))
                {
                    charFreq[c]++;
                }
                else
                {
                    charFreq[c] = 1;
                }
            }

            // Check if at most one character has an odd frequency
            int numOddFreq = 0;
            foreach (int freq in charFreq.Values)
            {
                if (freq % 2 == 1)
                {
                    numOddFreq++;
                    if (numOddFreq > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
