using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            int[] i1 = new int[] { 1, 2 };
            int[] i2 = new int[] { 3, 4 };

            Console.WriteLine($"{s.FindMedianSortedArrays(i1, i2)}"); 
            

        }
    }
}
