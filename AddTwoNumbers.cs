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
            BigInteger sum = ConvertandReverseLinkedList(l1) + ConvertandReverseLinkedList(l2);
            string sumstring = sum.ToString();         

            var reverseNums = sumstring.ToCharArray().Select(n => int.Parse(n.ToString()));
            return BuildNodes(reverseNums);
        }

        private ListNode BuildNodes(IEnumerable<int> nums, ListNode currentNode = null)
        {
            if (nums.Count() == 0)
                return currentNode;

            ListNode node = new ListNode(nums.First());
            node.next = currentNode;
            return BuildNodes(nums.Skip(1), node);
        }

        private BigInteger ConvertandReverseLinkedList(ListNode node)
        {
            string temp = string.Empty;
            while (node?.val != null)
            {
                temp = node.val.ToString() + temp;
                node = node.next;
            }
            return BigInteger.Parse(temp);
        }
    }
}