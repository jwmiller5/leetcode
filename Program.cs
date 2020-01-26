using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            string test = "PAYPALISHIRING";

            // Console.WriteLine(s.MyAtoi("42"));  
            Console.WriteLine(s.MyAtoi("   -42"));  
            // Console.WriteLine(s.MyAtoi("4193 with words"));  
            Console.WriteLine(s.MyAtoi("-7-"));  
            Console.WriteLine(s.MyAtoi("words and 987"));  
            Console.WriteLine(s.MyAtoi("-91283472332"));                                                             
        }
    }
}