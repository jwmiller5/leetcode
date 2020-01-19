using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace leetcode
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    public partial class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            return Add(l1, l2);
        }

        private ListNode LinkNodes(IEnumerable<ListNode> nodes, ListNode current = null)
        {
            if (nodes.Count() == 0)
                return current;

            ListNode node = nodes.First();
            node.next = current;
            return LinkNodes(nodes.Skip(1), node);
        }

        private ListNode Add(ListNode l1, ListNode l2)
        {
            List<ListNode> nodes = new List<ListNode>();
            int carry = 0;
            ListNode outNode = new ListNode(-1);
            while (l1?.val != null || l2?.val != null || carry > 0)
            {
                int op1 = l1?.val ?? 0;
                int op2 = l2?.val ?? 0;
                int sum = op1 + op2 + carry; 
                carry = sum / 10;
                int digit = sum % 10;
                nodes.Insert(0, new ListNode(digit));

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return LinkNodes(nodes);
        }
    }
}