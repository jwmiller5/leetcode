//https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/930/
 using System.Collections.Generic;
 namespace leetcode
 {
     public partial class Solution {
         /// left, then right, then root
        public IList<int> PostorderTraversal(TreeNode root) {
            List<int> inorder = new List<int>();            
            return ProcessNodePostOrder(root, inorder);
        }

        public List<int> ProcessNodePostOrder(TreeNode current, List<int> prev)
        {
            if (current == null)
                return prev;

            if (current.left != null)
                ProcessNodePostOrder(current.left, prev);

            if (current.right != null)
                ProcessNodePostOrder(current.right, prev);
                        
            prev.Add(current.val);

            return prev;
        }
    }
 }