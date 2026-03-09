// Problem 671. Second Minimum Node In a Binary Tree
// Link https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    TreeNode root = new TreeNode(2);
    root.left = new TreeNode(2);
    root.right = new TreeNode(5);
    root.right.left = new TreeNode(5);
    root.right.right = new TreeNode(7);

    Solution sol = new Solution();
    int output = sol.FindSecondMinimumValue(root);
    Console.WriteLine(output);
  }
  public int FindSecondMinimumValue(TreeNode root)
  {
    int min = root.val;
    long second = long.MaxValue;

    DFS(root, min, ref second);

    return second == long.MaxValue ? -1 : (int)second;
  }
  private void DFS(TreeNode node, int min, ref long second)
  {
    if (node == null) return;

    if (node.val > min && node.val < second)
    {
      second = node.val;
    }

    DFS(node.left, min, ref second);
    DFS(node.right, min, ref second);
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
