// Problem 897. Increasing Order Search Tree
// Link https://leetcode.com/problems/increasing-order-search-tree/description/
// Difficulty: Easy
class Solution {
  private TreeNode current;

  static void Main(string[] args) {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(5);
    root.left = new TreeNode(3);
    root.right = new TreeNode(6);

    root.left.left = new TreeNode(2);
    root.left.right = new TreeNode(4);

    root.right.right = new TreeNode(8);

    root.left.left.left = new TreeNode(1);

    root.right.right.left = new TreeNode(7);
    root.right.right.right = new TreeNode(9);

    TreeNode result = sol.IncreasingBST(root);

    Console.WriteLine("Output: " + TreeToLeetCodeFormat(result));
  }

  public TreeNode IncreasingBST(TreeNode root) {
    TreeNode dummy = new TreeNode(0);
    current = dummy;

    InOrder(root);

    return dummy.right;
  }

  private void InOrder(TreeNode node) {
    if (node == null) return;

    InOrder(node.left);

    node.left = null;
    current.right = node;
    current = node;

    InOrder(node.right);
  }

  public static string TreeToLeetCodeFormat(TreeNode root)
  {
      if (root == null)
          return "[]";

      List<string> result = new List<string>();
      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      while (queue.Count > 0)
      {
          TreeNode node = queue.Dequeue();

          if (node == null)
          {
              result.Add("null");
          }
          else
          {
              result.Add(node.val.ToString());
              queue.Enqueue(node.left);
              queue.Enqueue(node.right);
          }
      }

      // Remove trailing nulls
      while (result.Count > 0 && result[result.Count - 1] == "null")
      {
          result.RemoveAt(result.Count - 1);
      }

      return "[" + string.Join(",", result) + "]";
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
