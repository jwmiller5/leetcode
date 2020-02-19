
namespace leetcode
{
    //  public class ListNode {
    //      public int val;
    //      public ListNode next;
    //      public ListNode(int x) { val = x; }
    //  }
    
    public partial class Solution {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {            
            ListNode root = GetNextNode(ref l1, ref l2);
            var current = root;

            while (l1 != null || l2 != null)
            {
                current.next = GetNextNode(ref l1, ref l2);
                current = current.next;
            }
            
            return root;
        }

        private ListNode GetNextNode(ref ListNode l1, ref ListNode l2)
        {
            ListNode next;
            if (l1 == null)
            {
                next = l2;
                l2 = null;
                return next;
            }


            if (l2 == null)
            {
                next = l1;
                l1 = null;
                return next;
            }

            if (l1.val < l2.val)
            {
                next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                next = new ListNode(l2.val);
                l2 = l2.next;
            }

            return next;
        }
    }
}