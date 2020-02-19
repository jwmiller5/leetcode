using System.Collections.Generic;
namespace leetcode 
{
    public partial class Solution {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            var initial = head;
            var buffer = new List<ListNode>(n + 1);
            buffer.Add(head);            
            while (head.next != null)
            {
                if (buffer.Count == buffer.Capacity)
                    buffer.RemoveAt(0);
                
                buffer.Add(head.next);

                head = head.next;
            }

            if (n == 1)
            {
                if (buffer.Count == 1)
                    return null;
                else
                {
                    buffer[buffer.Count - 2].next = null;
                    return initial;
                }
            }

            if (buffer.Count == buffer.Capacity)
            {
                buffer[0].next = buffer[2];
                return initial;
            }
            else //buffer count is less than capacity. Trim the first entry
            {
                return buffer[1];
            }

        }
    }
}