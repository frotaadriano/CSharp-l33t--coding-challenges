using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public static class AnagramChecker
    {
        /*
            Challenge Title: Anagram Checker

            Difficulty: Easy

            Prompt: Create a C# function that checks whether two given strings are anagrams. 
                    An anagram is a word or phrase formed by rearranging the letters of a 
                    different word or phrase, typically using all the original letters 
                    exactly once.

            Function Signature:
                public static bool IsAnagram(string s1, string s2)

            IsAnagram("anagram", "nagaram") // true
                IsAnagram("hello", "world") // false 

         */
        public static bool AreAnagrams(string word1, string word2)
        {
            // Convert strings to char arrays and sort them
            var sorted1 = word1.ToLower().ToCharArray().OrderBy(c => c).ToArray();
            var sorted2 = word2.ToLower().ToCharArray().OrderBy(c => c).ToArray();

            // Compare sorted arrays
            return sorted1.SequenceEqual(sorted2);
        }
    }
}
