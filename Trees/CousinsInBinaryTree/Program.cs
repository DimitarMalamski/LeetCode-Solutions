// Problem 993. Cousins in Binary Tree
// Link https://leetcode.com/problems/cousins-in-binary-tree/description/
// Difficulty: Easy
class Solution {
  static void Main(string[] args) {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(1);
    root.left = new TreeNode(2);
    root.right = new TreeNode(3);
    root.left.left = new TreeNode(4);

    int x = 4, y = 3;
    bool output = IsCousins(root, x, y);
    Console.WriteLine(output);
  }
  public static bool IsCousins(TreeNode root, int x, int y) {
    Queue<(TreeNode node, TreeNode parent)> queue = new Queue<(TreeNode, TreeNode)>();

    queue.Enqueue((root, null));

    while (queue.Count > 0)
    {
      int levelSize = queue.Count;

      TreeNode parentX = null;
      TreeNode parentY = null;

      for (int i = 0; i < levelSize; i++)
      {
        var current = queue.Dequeue();
        TreeNode node = current.node;
        TreeNode parent = current.parent;

        if (node.val == x)
        {
          parentX = parent;
        }

        if (node.val == y)
        {
          parentY = parent;
        }

        if (node.left != null)
        {
          queue.Enqueue((node.left, node));
        }

        if (node.right != null)
        {
          queue.Enqueue((node.right, node));
        }
      }

      if (parentX != null && parentY != null)
      {
        return parentX != parentY;
      }

      if (parentX != null || parentY != null)
      {
        return false;
      }
    }

    return false;
  }

  public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }
}
