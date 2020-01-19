using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace leetcode
{
    public partial class Solution {
        public int LengthOfLongestSubstring(string s) {
            var chars = s.ToCharArray();
            List<char> longestCharArray = new List<char>();
            int longestArrayLength = 0;
            for (int i = 0; i < chars.Count(); i++)
            {
                List<char> currentSubString = new List<char>() { chars[i] };
                int j = i + 1;
                while (j < chars.Count() && !currentSubString.Contains(chars[j]))
                {
                    currentSubString.Add(chars[j++]);
                }

                if (currentSubString.Count() > longestArrayLength)
                {
                    longestCharArray = currentSubString;
                    longestArrayLength = currentSubString.Count();
                }
                
            }

            StringBuilder b = new StringBuilder();
            foreach (char c in longestCharArray)
            {
                b.Append(c);
            }
            Console.WriteLine(b.ToString());
            return longestArrayLength;
        }
    }
}