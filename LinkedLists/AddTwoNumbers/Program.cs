// Problem 2. Add Two Numbers
// Link https://leetcode.com/problems/add-two-numbers/description/
// Difficulty: Medium
class Solution
{
  static void Main(string[] args)
  {
    int[] listOne = { 2, 4, 3 };
    int[] listTwo = { 5, 6, 4 };

    ListNode l1 = BuildLinkedList(listOne);
    ListNode l2 = BuildLinkedList(listTwo);

    ListNode output = AddTwoNumbers(l1, l2);

    PrintList(output);
  }
  public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
  {
    ListNode dummy = new ListNode(0);
    ListNode current = dummy;

    int carry = 0;

    while (l1 != null || l2 != null || carry != 0)
    {
      int val1 = l1 != null ? l1.val : 0;
      int val2 = l2 != null ? l2.val : 0;

      int sum = val1 + val2 + carry;

      carry = sum / 10;

      current.next = new ListNode(sum % 10);
      current = current.next;

      if (l1 != null) l1 = l1.next;
      if (l2 != null) l2 = l2.next;
    }

    return dummy.next;
  }
  static ListNode BuildLinkedList(int[] nums)
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
  static void PrintList(ListNode node)
  {
    while (node != null)
    {
      Console.Write(node.val + ",");
      node = node.next;
    }

    Console.WriteLine();
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
