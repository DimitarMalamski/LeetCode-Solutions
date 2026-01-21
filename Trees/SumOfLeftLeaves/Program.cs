// Problem 404. Sum of Left Leaves
// Link https://leetcode.com/problems/sum-of-left-leaves/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(3);
      root.left = new TreeNode(9);
      root.right = new TreeNode(20);

      root.right.left = new TreeNode(15);
      root.right.right = new TreeNode(7);

      int output = sol.SumOfLeftLeaves(root);
      Console.WriteLine(output);
   }
   public int SumOfLeftLeaves(TreeNode root)
   {
      if (root == null) return 0;

      int sum = 0;

      if (root.left != null
         && root.left.left == null
         && root.left.right == null)
      {
         sum += root.left.val;
      }

      sum += SumOfLeftLeaves(root.left);
      sum += SumOfLeftLeaves(root.right);

      return sum;
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
