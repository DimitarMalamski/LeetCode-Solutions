// Problem 700. Search in a Binary Search Tree
// Link https://leetcode.com/problems/search-in-a-binary-search-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    TreeNode root = new TreeNode(4);
    root.left = new TreeNode(2);
    root.right = new TreeNode(7);

    root.left.left = new TreeNode(1);
    root.left.right = new TreeNode(3);

    Solution sol = new Solution();
    int val = 2;
    TreeNode output = sol.SearchBST(root, val);

    PrintTree(output);
  }
  public TreeNode SearchBST(TreeNode root, int val)
  {
    if (root == null) return null;

    if (root.val == val) return root;

    if (val < root.val) return SearchBST(root.left, val);

    return SearchBST(root.right, val);
  }
  public static void PrintTree(TreeNode node)
  {
    if (node == null)
    {
      Console.WriteLine("null");
      return;
    }

    Console.WriteLine(node.val);
    PrintTree(node.left);
    PrintTree(node.right);
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
