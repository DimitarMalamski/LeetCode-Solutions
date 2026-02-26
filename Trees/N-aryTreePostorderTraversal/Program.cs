// Problem 590. N-ary Tree Postorder Traversal
// Link https://leetcode.com/problems/n-ary-tree-postorder-traversal/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int?[] input = { 1,null,3,2,4,null,5,6 };

    Node root = BuildTree(input);

    var output = PostorderOptimized(root);

    Console.WriteLine(string.Join(", ", output));
  }
  public static IList<int> PostorderOptimized(Node root)
  {
    List<int> result = new List<int>();
    if (root == null) return result;

    Stack<Node> stack = new Stack<Node>();
    stack.Push(root);

    while (stack.Count > 0)
    {
      Node node = stack.Pop();
      result.Add(node.val);

      foreach (var child in node.children)
      {
        stack.Push(child);
      }
    }

    result.Reverse();
    return result;
  }
  public static IList<int> Postorder(Node root)
  {
    List<int> result = new List<int>();
    DFS(root, result);
    return result;
  }
  private static void DFS(Node node, List<int> result)
  {
    if (node == null) return;

    foreach (var child in node.children)
    {
      DFS(child, result);
    }

    result.Add(node.val);
  }
  public static Node? BuildTree(int?[] data)
  {
    if (data == null || data.Length == 0)
      return null;

    Node root = new Node(data[0]!.Value);
    root.children = new List<Node>();

    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);

    int i = 1;

    while (queue.Count > 0 && i < data.Length)
    {
      Node parent = queue.Dequeue();

      if (data[i] == null)
      {
        i++;
      }

      while (i < data.Length && data[i] != null)
      {
        Node child = new Node(data[i]!.Value);
        child.children = new List<Node>();

        parent.children.Add(child);
        queue.Enqueue(child);
        i++;
      }
    }

    return root;
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
