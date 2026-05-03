// Problem 965. Univalued Binary Tree
// Link https://leetcode.com/problems/univalued-binary-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution solution = new Solution();

    TreeNode root1 = new TreeNode(1);
    root1.left = new TreeNode(1);
    root1.right = new TreeNode(1);
    root1.left.left = new TreeNode(1);
    root1.left.right = new TreeNode(1);
    root1.right.right = new TreeNode(1);

    Console.WriteLine(solution.IsUnivalTree(root1));
  }
  public bool IsUnivalTree(TreeNode root)
  {
    return CheckTree(root, root.val);
  }
  private static bool CheckTree(TreeNode node, int targetValue)
  {
    if (node == null)
    {
      return true;
    }

    if (node.val != targetValue)
    {
      return false;
    }

    return CheckTree(node.left, targetValue) &&
      CheckTree(node.right, targetValue);
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
