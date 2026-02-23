// Problem 572. Subtree of Another Tree
// Link https://leetcode.com/problems/subtree-of-another-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    // Main tree
    TreeNode root = new TreeNode(3);
    root.left = new TreeNode(4);
    root.right = new TreeNode(5);
    root.left.left = new TreeNode(1);
    root.left.right = new TreeNode(2);

    // Subtree
    TreeNode subRoot = new TreeNode(4);
    subRoot.left = new TreeNode(1);
    subRoot.right = new TreeNode(2);

    bool output = sol.IsSubtree(root, subRoot);
    Console.WriteLine(output);
  }
  public bool IsSubtree(TreeNode root, TreeNode subRoot)
  {
    if (root == null) return false;

    if (IsSameTree(root, subRoot)) return true;

    return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
  }

  private bool IsSameTree(TreeNode a, TreeNode b) {
    if (a == null && b == null) return true;

    if (a == null || b == null) return false;

    if (a.val != b.val) return false;

    return IsSameTree(a.left, b.left) && IsSameTree(a.right, b.right);
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
