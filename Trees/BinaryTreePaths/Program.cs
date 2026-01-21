// Problem 257. Binary Tree Paths
// Link https://leetcode.com/problems/binary-tree-paths/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(1);
      root.left = new TreeNode(2);
      root.right = new TreeNode(3);

      root.left.right = new TreeNode(5);

      IList<string> output = sol.BinaryTreePaths(root);
      Console.WriteLine(string.Join(", ", output));
   }
   public IList<string> BinaryTreePaths(TreeNode root)
   {
      IList<string> result = new List<string>();
      if (root == null) return result;

      DFS(root, "", result);
      return result;
   }
   private void DFS(TreeNode node, string path, IList<string> result)
   {
      if (node == null) return;

      path += node.val;

      if (node.left == null && node.right == null)
      {
         result.Add(path);
         return;
      }

      path += "->";
      DFS(node.left, path, result);
      DFS(node.right, path, result);
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
