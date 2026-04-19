// Problem 226. Invert Binary Tree
// Link https://leetcode.com/problems/invert-binary-tree/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      TreeNode root = new TreeNode(4,
         new TreeNode(2, new TreeNode(1), new TreeNode(3)),
         new TreeNode(7, new TreeNode(6), new TreeNode(9))
      );

      Solution sol = new Solution();
      TreeNode inverted = sol.InvertTree(root);
   }

   public TreeNode InvertTree(TreeNode root)
   {
      if (root == null) return null;

      TreeNode temp = root.left;
      root.left = root.right;
      root.right = temp;

      InvertTree(root.left);
      InvertTree(root.right);

      return root;
   }
   public class TreeNode
   {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
         this.val = val;
         this.left = left;
         this.right = right;
      }
   }
}
