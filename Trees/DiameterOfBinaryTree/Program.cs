// Problem 543. Diameter of Binary Tree
// Link https://leetcode.com/problems/diameter-of-binary-tree/description/
// Difficulty: Easy
class Solution
{
  private int diameter = 0;
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(1);
    root.left = new TreeNode(2);
    root.right = new TreeNode(3);

    root.left.left = new TreeNode(4);
    root.left.right = new TreeNode(5);

    int output = sol.DiameterOfBinaryTree(root);
    Console.WriteLine(output);
  }

  public int DiameterOfBinaryTree(TreeNode root)
  {
    Height(root);
    return diameter;
  }

  private int Height(TreeNode node)
  {
    if (node == null) return 0;

    int leftHeight = Height(node.left);
    int rightHeight = Height(node.right);

    diameter = Math.Max(diameter, leftHeight + rightHeight);

    return 1 + Math.Max(leftHeight, rightHeight);
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
