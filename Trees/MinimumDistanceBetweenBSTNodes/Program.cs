// Problem 783. Minimum Distance Between BST Nodes
// Link https://leetcode.com/problems/minimum-distance-between-bst-nodes/description/
// Difficulty: Easy
class Solution
{
  private int minDiff = int.MaxValue;
  private TreeNode prev = null;
  static void Main(string[] args)
  {
    TreeNode root = new TreeNode(4);
    root.left = new TreeNode(2);
    root.right = new TreeNode(6);

    root.left.left = new TreeNode(1);
    root.left.right = new TreeNode(3);

    Solution sol = new Solution();
    int output = sol.MinDiffInBST(root);

    Console.WriteLine(output);
  }
  public int MinDiffInBST(TreeNode root)
  {
    InOrder(root);
    return minDiff;
  }
  private void InOrder(TreeNode node)
  {
    if (node == null) return;

    InOrder(node.left);

    if (prev != null)
    {
      minDiff = Math.Min(minDiff, node.val - prev.val);
    }

    prev = node;

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
