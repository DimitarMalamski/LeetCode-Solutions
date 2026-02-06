// Problem 501. Find Mode in Binary Search Tree
// Link https://leetcode.com/problems/find-mode-in-binary-search-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(1);
    root.right = new TreeNode(2);

    root.right.left = new TreeNode(2);

    int[] output = sol.FindMode(root);
    Console.WriteLine(string.Join(",", output));
  }
  public int[] FindMode(TreeNode root)
  {
    int? prev = null;
    int count = 0;
    int maxCount = 0;
    List<int> nodes = new List<int>();

    void InOrder(TreeNode node)
    {
      if (node == null) return;

      InOrder(node.left);

      if (prev == node.val)
      {
        count++;
      }
      else
      {
        count = 1;
        prev = node.val;
      }

      if (count > maxCount)
      {
        maxCount = count;
        nodes.Clear();
        nodes.Add(node.val);
      }
      else if (count == maxCount)
      {
        nodes.Add(node.val);
      }

      InOrder(node.right);
    }

    InOrder(root);
    return nodes.ToArray();
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
