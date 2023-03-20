using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Substring.Resolution
{
    class SubstringResolution
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
