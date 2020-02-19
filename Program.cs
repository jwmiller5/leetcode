using System;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(3);

            var list2 = new ListNode(2);
            list2.next = new ListNode(4);
            list2.next.next = new ListNode(6);

            var merged = s.MergeTwoLists(list1, list2);

            do
            {
                Console.WriteLine(merged.val);
                merged = merged.next;
            } while (merged != null);
            // Console.WriteLine()

            // // Console.WriteLine(s.MyAtoi("42"));  
            // Console.WriteLine(s.MyAtoi("   -42"));  
            // // Console.WriteLine(s.MyAtoi("4193 with words"));  
            // Console.WriteLine(s.MyAtoi("-7-"));  
            // Console.WriteLine(s.MyAtoi("words and 987"));  
            // Console.WriteLine(s.MyAtoi("-91283472332"));                                                             
        }
    }
}