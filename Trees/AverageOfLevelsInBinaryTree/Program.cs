// Problem 637. Average of Levels in Binary Tree
// Link https://leetcode.com/problems/average-of-levels-in-binary-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    TreeNode root = new TreeNode(3);
    root.left = new TreeNode(9);
    root.right = new TreeNode(20);

    root.right.left = new TreeNode(15);
    root.right.right = new TreeNode(7);

    IList<double> output = sol.AverageOfLevels(root);
    Console.WriteLine(string.Join(", ", output));
  }
  public IList<double> AverageOfLevels(TreeNode root)
  {
    List<double> result = new List<double>();
    Queue<TreeNode> queue = new Queue<TreeNode>();

    queue.Enqueue(root);

    while (queue.Count > 0)
    {
      int lvlSize = queue.Count;
      double sum = 0;

      for (int i = 0; i < lvlSize; i++)
      {
        TreeNode node = queue.Dequeue();
        sum += node.val;

        if (node.left != null)
        {
          queue.Enqueue(node.left);
        }

        if (node.right != null)
        {
          queue.Enqueue(node.right);
        }
      }

      result.Add(sum / lvlSize);
    }

    return result;
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
