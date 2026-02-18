// Problem 559. Maximum Depth of N-ary Tree
// Link https://leetcode.com/problems/maximum-depth-of-n-ary-tree/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    Solution sol = new Solution();

    Node node6 = new Node(6, new List<Node>());
    Node node5 = new Node(5, new List<Node>());

    Node node4 = new Node(3, new List<Node> { node6, node5 });

    Node node3 = new Node(2, new List<Node>());
    Node node2 = new Node(4, new List<Node>());

    Node root = new Node(1, new List<Node> { node2, node3, node4 });

    int output = sol.MaxDepth(root);
    Console.WriteLine(output);
  }
  public int MaxDepth(Node root)
  {
    if (root == null) return 0;

    if (root.children == null || root.children.Count == 0) return 1;

    int maxDepth = 0;

    foreach (Node child in root.children)
    {
      maxDepth = Math.Max(maxDepth, MaxDepth(child));
    }

    return 1 + maxDepth;
  }
  public class Node
  {
    public int val;
    public IList<Node> children;
    public Node() { }
    public Node(int _val)
    {
      val = _val;
    }
    public Node(int _val, IList<Node> _children)
    {
      val = _val;
      children = _children;
    }
  }
}
