// Problem 222. Count Complete Tree Nodes
// Link https://leetcode.com/problems/count-complete-tree-nodes/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(1);
      root.left = new TreeNode(2);
      root.right = new TreeNode(3);

      root.left.left = new TreeNode(4);
      root.left.right = new TreeNode(5);

      root.right.left = new TreeNode(6);

      int output = sol.CountNodes(root);
      Console.WriteLine(output); 
   }

   public int CountNodes(TreeNode root)
   {
      if (root == null) return 0;

      int leftHeight = GetLeftHeight(root);
      int rightHeight = GetRightHeight(root);

      if (leftHeight == rightHeight)
      {
         return (1 << leftHeight) - 1; // or Math.Pow(2, leftHeight) - 1
      }

      return 1 + CountNodes(root.left) + CountNodes(root.right);
   }

   private int GetRightHeight(TreeNode node)
   {
      int height = 0;

      while (node != null)
      {
         height++;
         node = node.right;
      }

      return height;
   }
   private int GetLeftHeight(TreeNode node)
   {
      int height = 0;

      while (node != null)
      {
         height++;
         node = node.left;
      }

      return height;
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
