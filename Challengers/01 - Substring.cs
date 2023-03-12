using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    /*
     Problem Statement
    You are given a string of lowercase English letters. Your task is to find the length of the longest substring that contains at most k distinct characters.

    Write a function longestSubstring(string s, int k) that takes a string s and an integer k as input, and returns the length of the longest substring that contains at most k distinct characters.

    _______________________________________________
    Example
    longestSubstring("abcbdbdbbdcdabd", 2) => 7
    ______________________________________________
    In this example, the longest substring that contains at most 2 distinct characters is "bdbdbbd", which has a length of 7.

    Constraints
    The input string s contains only lowercase English letters.
    1 ≤ k ≤ length of s.

     */
    public static class Substring01
    {
        public static int LongestSubstring(string s, int k)
        {
            int n = s.Length;
            int maxLen = 0;
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            int distinctCount = 0;
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                char c = s[right];
                if (!charCounts.ContainsKey(c))
                {
                    distinctCount++;
                    charCounts[c] = 0;
                }
                charCounts[c]++;

                while (distinctCount > k)
                {
                    char leftChar = s[left];
                    charCounts[leftChar]--;
                    if (charCounts[leftChar] == 0)
                    {
                        distinctCount--;
                        charCounts.Remove(leftChar);
                    }
                    left++;
                }

                if (distinctCount <= k)
                {
                    maxLen = Math.Max(maxLen, right - left + 1);
                }
            }

            return maxLen;
        }


    }
}
