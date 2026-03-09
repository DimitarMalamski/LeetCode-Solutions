// Problem 653. Two Sum IV - Input is a BST
// Link https://leetcode.com/problems/two-sum-iv-input-is-a-bst/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(5);
    root.left = new TreeNode(3);
    root.right = new TreeNode(6);

    root.left.left = new TreeNode(2);
    root.left.right = new TreeNode(4);

    root.right.right = new TreeNode(7);

    int k = 9;

    bool output = sol.FindTarget(root, k);
    Console.WriteLine(output);
  }
  public bool FindTarget(TreeNode root, int k)
  {
    HashSet<int> seen = new HashSet<int>();
    return DFS(root, k, seen);
  }
  private bool DFS(TreeNode node, int k, HashSet<int> seen)
  {
    if (node == null) return false;

    if (seen.Contains(k - node.val)) return true;

    seen.Add(node.val);

    return DFS(node.left, k, seen) || DFS(node.right, k, seen);
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
