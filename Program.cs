using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            string testcase = "III";
            string t2 = "IV";
            string t3 = "IX";
            string t4 = "XCIX";
            string t5 = "XLV";
            string t6 = "MCMXCIX";
            string t7 = "MCMLXXXIII";
            var result = s.RomanToInt(testcase);
            Console.WriteLine($"{testcase} - {result}");
            Console.WriteLine($"{t2} - {s.RomanToInt(t2)}");
            Console.WriteLine($"{t3} - {s.RomanToInt(t3)}");   
            Console.WriteLine($"{t4} - {s.RomanToInt(t4)}");   
            Console.WriteLine($"{t5} - {s.RomanToInt(t5)}");   
            Console.WriteLine($"{t6} - {s.RomanToInt(t6)}");   
            Console.WriteLine($"{t7} - {s.RomanToInt(t7)}");   

        }
    }
}
