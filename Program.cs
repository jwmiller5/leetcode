using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            string[] s1 = new string[] {"abcabcbb", "bbbbb", "pwwkew"};

            foreach (string stest in s1)
            {
                Console.WriteLine($"{stest} has the longest substring {s.LengthOfLongestSubstring(stest)}"); 
            }

        }
    }
}
