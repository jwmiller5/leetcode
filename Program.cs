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
            list1.next.next.next = new ListNode(4);
            list1.next.next.next.next = new ListNode(5);
            list1.next.next.next.next.next = new ListNode(6);

            var remove = s.RemoveNthFromEnd(list1, 5);

            do
            {
                Console.WriteLine(remove.val);
                remove = remove.next;
            } while (remove != null);                                                         
        }
    }
}