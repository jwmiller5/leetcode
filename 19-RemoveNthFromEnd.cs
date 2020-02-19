using System.Collections.Generic;
namespace leetcode 
{
    public partial class Solution {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            var list = new List<ListNode>() { head };            
            while (head.next != null)
            {
                list.Add(head.next);
                head = head.next;
            }

            //Remove the first item
            if (n == list.Count)
            {
                if (list.Count > 1)
                    return list[1];
                else
                    return null;    
            }

            
            //Remove the last item
            if (n == 1)
            {
                list[list.Count - 2].next = null;                            
                return list[0];
            }

            list[list.Count - (n + 1)].next = list[list.Count - n + 1];
            return list[0]; 
        }
    }
}