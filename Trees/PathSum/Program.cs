// Problem 112. Path Sum
// Link https://leetcode.com/problems/path-sum/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(5);
      root.left = new TreeNode(4);
      root.right = new TreeNode(8);

      root.left.left = new TreeNode(11);
      root.left.left.left = new TreeNode(7);
      root.left.left.right = new TreeNode(2);

      root.right.left = new TreeNode(13);
      root.right.right = new TreeNode(4);
      root.right.right.right = new TreeNode(1);

      int targetSum = 22;

      bool output = sol.HasPathSum(root, targetSum);
      Console.WriteLine(output);
   }

   public bool HasPathSum(TreeNode root, int targetSum)
   {
      if (root == null) return false;

      if (root.left == null && root.right == null)
      {
         return targetSum == root.val;
      }

      int remaining = targetSum - root.val;

      return HasPathSum(root.left, remaining)
         || HasPathSum(root.right, remaining);
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
