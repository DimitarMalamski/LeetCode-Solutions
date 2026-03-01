// Problem 2807. Insert Greatest Common Divisors in Linked List
// Link https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/description/
// Difficulty: Medium
class Solution
{
  static void Main(string[] args)
  {
    int[] list = { 18,6,10,3 };

    ListNode head = BuildLinkedList(list);

    ListNode output = InsertGreatestCommonDivisors(head);

    PrintList(output);
  }
  public static ListNode InsertGreatestCommonDivisors(ListNode head)
  {
    if (head == null && head.next == null) return head;

    ListNode current = head;

    while (current != null && current.next != null)
    {
      int value = GCD(current.val, current.next.val);

      ListNode newNode = new ListNode(value);

      newNode.next = current.next;
      current.next = newNode;

      current = newNode.next;
    }

    return head;
  }
  public static int GCD(int a, int b) {
    while (b != 0)
    {
      int temp = b;
      b = a % b;
      a = temp;
    }

    return a;
  }
  public static void PrintList(ListNode node)
  {
    while (node != null)
    {
      Console.Write(node.val + ",");
      node = node.next;
    }

    Console.WriteLine();
  }
  public static ListNode BuildLinkedList(int[] nums)
  {
    if (nums.Length == 0) return null;

    ListNode head = new ListNode(nums[0]);
    ListNode current = head;

    for (int i = 1; i < nums.Length; i++)
    {
      current.next = new ListNode(nums[i]);
      current = current.next;
    }

    return head;
  }
  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
  }
}
