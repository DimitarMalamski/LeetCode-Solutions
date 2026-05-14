// Problem 1022. Sum of Root To Leaf Binary Numbers
// Link https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    TreeNode root = new TreeNode(1);
    root.left = new TreeNode(0);
    root.left.left = new TreeNode(0);
    root.left.right = new TreeNode(1);

    root.right = new TreeNode(1);
    root.right.left = new TreeNode(0);
    root.right.right = new TreeNode(1);

    Solution sol = new Solution();
    int output = sol.SumRootToLeaf(root);
    Console.WriteLine(output);
  }
  public int SumRootToLeaf(TreeNode root)
  {
    return DFS(root, 0);
  }

  private static int DFS(TreeNode node, int current)
  {
    if (node == null) return 0;

    current = (current << 1) | node.val;

    if (node.left == null && node.right == null) return current;

    return DFS(node.left, current) + DFS(node.right, current);
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
