// Problem 617. Merge Two Binary Trees
// Link https://leetcode.com/problems/merge-two-binary-trees/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    TreeNode root1 = new TreeNode(1);
    root1.left = new TreeNode(3);
    root1.right = new TreeNode(2);
    root1.left.left = new TreeNode(5);

    TreeNode root2 = new TreeNode(2);
    root2.left = new TreeNode(1);
    root2.right = new TreeNode(3);
    root2.left.right = new TreeNode(4);
    root2.right.right = new TreeNode(7);

    Solution sol = new Solution();
    TreeNode output = sol.MergeTrees(root1, root2);

    List<int> result = sol.ToList(output);
    Console.WriteLine(string.Join(",", result));
  }
  public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
  {
    if (root1 == null) return root2;
    if (root2 == null) return root1;

    root1.val += root2.val;
    root1.left = MergeTrees(root1.left, root2.left);
    root1.right = MergeTrees(root1.right, root2.right);

    return root1;
  }

  private List<int> ToList(TreeNode root)
  {
    List<int> result = new List<int>();
    InOrder(root, result);
    return result;
  }
  private void InOrder(TreeNode node, List<int> list)
  {
    if (node == null) return;

    InOrder(node.left, list);
    list.Add(node.val);
    InOrder(node.right, list);
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
