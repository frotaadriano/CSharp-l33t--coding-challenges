using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    public class Pangram
    {
        public const string VOCAB = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Challenge Name: Pangram Checker
        /// Difficulty Level: Intermediate
        /// Description: Write a function that takes a string as input and returns a boolean value indicating whether the string is a pangram or not.A pangram is a sentence that contains every letter of the alphabet at least once. The input string can contain both uppercase and lowercase letters and may have punctuation and spaces, which should be ignored. The function should return true if the input string is a pangram, false otherwise.
        /// Example:
        /// Input: "The quick brown fox jumps over the lazy dog."
        /// Output: true 
        /// Input: "This is not a pangram."
        /// Output: false
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        public static string IsPangram(string phrase)
        {
            phrase = phrase.ToUpper(); 
            foreach (var v in VOCAB)
            {
                
                if (!phrase.Contains(v))
                {
                    return $"(FALSE) > {phrase}";
                }
            }  
            return $"(TRUE) > {phrase}";
            
             /*
             * The complexity of this solution is O(n*m), where n is the length of the input string and m is the length of the VOCAB array. 
             * This is because you are iterating over each character in the VOCAB array for each character in the input string, which 
             * can potentially lead to a large number of iterations.
             */ 
        } 

        /*
          A more efficient solution would be to use a HashSet<char> to store the unique characters in the input string and 
            then check if the size of the set is equal to the size of the English alphabet (26). 
            This solution would have a time complexity of O(n), 
            which is better than O(n*m).
         */
        public static string IsPangramOptmized(string phrase)
        {
            phrase = phrase.ToUpper();
            var set = new HashSet<char>();
            foreach (var c in phrase)
            {
                if (Char.IsLetter(c))
                {
                    set.Add(c);
                }
            }
            if (set.Count == 26)
            {
                return $"(TRUE) > {phrase}";
            }
            else
            {
                return $"(FALSE) > {phrase}";
            }
        } 
    }
}
