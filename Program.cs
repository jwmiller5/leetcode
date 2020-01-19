using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            ListNode t1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) { next = new ListNode(1)}}};
            ListNode t2 = new ListNode(5) { next = new ListNode(6) { next = new ListNode(4)}};
            var result = s.AddTwoNumbers(t1, t2);
            Console.Write("{");
            while (result?.val != null)
            {
                Console.Write($"{result.val} ");
                result = result.next;
            }
            Console.Write("}");   

        }
    }
}
