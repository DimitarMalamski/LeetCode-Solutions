// Problem 938. Range Sum of BST
// Link https://leetcode.com/problems/range-sum-of-bst/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    TreeNode root = new TreeNode(10);
    root.left = new TreeNode(5);
    root.right = new TreeNode(15);

    root.left.left = new TreeNode(3);
    root.left.right = new TreeNode(7);

    root.right.right = new TreeNode(18);

    int low = 7;
    int high = 15;

    Solution solution = new Solution();

    int result = solution.RangeSumBST(root, low, high);

    Console.WriteLine(result);
  }
  public int RangeSumBST(TreeNode root, int low, int high)
  {
    if (root == null) return 0;

    if (root.val < low)
    {
      return RangeSumBST(root.right, low, high);
    }

    if (root.val > high)
    {
      return RangeSumBST(root.left, low, high);
    }

    return root.val 
      + RangeSumBST(root.left, low, high) 
      + RangeSumBST(root.right, low, high);
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
