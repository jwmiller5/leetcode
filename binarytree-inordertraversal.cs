
 using System.Collections.Generic;
 namespace leetcode
 {
 
 public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
 }
 

     public partial class Solution {
         /// Left, then root, then right
        public IList<int> InorderTraversal(TreeNode root) {
            List<int> inorder = new List<int>();            
            return ProcessNode(root, inorder);
        }

        public List<int> ProcessNode(TreeNode current, List<int> prev)
        {
            if (current == null)
                return prev;

            if (current.left != null)
            {
                ProcessNode(current.left, prev);
            }

            prev.Add(current.val);

            if (current.right != null)
            {
                ProcessNode(current.right, prev);
            }

            return prev;
        }
    }
 }