// Problem 1290. Convert Binary Number in a Linked List to Integer
// Link https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] values = { 1, 0, 1 };

    ListNode head = BuildLinkedList(values);

    Solution solution = new Solution();
    int result = solution.GetDecimalValue(head);

    Console.WriteLine(result);
  }

  public int GetDecimalValue(ListNode head)
  {
    int result = 0;

    while (head != null)
    {
      result = result * 2 + head.val;
      head = head.next;
    }

    return result;
  }
  private static ListNode BuildLinkedList(int[] values)
  {
    if (values.Length == 0)
    {
      return null!;
    }

    ListNode head = new ListNode(values[0]);
    ListNode current = head;

    for (int i = 1; i < values.Length; i++)
    {
      current.next = new ListNode(values[i]);
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
