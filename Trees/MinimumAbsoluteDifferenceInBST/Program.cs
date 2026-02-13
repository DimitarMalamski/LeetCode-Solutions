// Problem 530. Minimum Absolute Difference in BST
// Link https://leetcode.com/problems/minimum-absolute-difference-in-bst/description/
// Difficulty: Easy
class Solution
{
  private static int? prev = null;
  private static int minDiff = int.MaxValue; 
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(4);
    root.left = new TreeNode(2);
    root.right = new TreeNode(8);

    root.left.left = new TreeNode(1);
    root.left.right = new TreeNode(3);

    int output = sol.GetMinimumDifference(root);
    Console.WriteLine(output);
  }
  public int GetMinimumDifference(TreeNode root)
  {
    InOrder(root);
    return minDiff;
  }

  private static void InOrder(TreeNode node)
  {
    if (node == null) return;

    InOrder(node.left);

    if (prev != null)
    {
      minDiff = Math.Min(minDiff, node.val - prev.Value);
    }

    prev = node.val;

    InOrder(node.right);
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
