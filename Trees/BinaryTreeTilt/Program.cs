// Problem 563. Binary Tree Tilt
// Link https://leetcode.com/problems/binary-tree-tilt/description/
// Difficulty: Easy
class Solution
{
  private int totalTilt = 0;
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(1);
    root.left = new TreeNode(2);
    root.right = new TreeNode(3);

    int output = sol.FindTilt(root);
    Console.WriteLine(output);
  }
  public int FindTilt(TreeNode root)
  {
    GetSum(root);
    return totalTilt;
  }
  private int GetSum(TreeNode node)
  {
    if (node == null) return 0;

    int leftSum = GetSum(node.left);
    int rightSum = GetSum(node.right);

    totalTilt += Math.Abs(leftSum - rightSum);

    return leftSum + rightSum + node.val;
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
