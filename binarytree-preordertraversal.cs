
 using System.Collections.Generic;
 namespace leetcode
 {
     public partial class Solution {
         /// root, then left, then right
        public IList<int> PreorderTraversal(TreeNode root) {
            List<int> inorder = new List<int>();            
            return ProcessNodePreOrder(root, inorder);
        }

        public List<int> ProcessNodePreOrder(TreeNode current, List<int> prev)
        {
            if (current == null)
                return prev;

            prev.Add(current.val);

            if (current.left != null)
            {
                ProcessNodePreOrder(current.left, prev);
            }

            if (current.right != null)
            {
                ProcessNodePreOrder(current.right, prev);
            }

            return prev;
        }
    }
 }