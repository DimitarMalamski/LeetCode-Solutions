// Problem 234. Palindrome Linked List
// Link https://leetcode.com/problems/palindrome-linked-list/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 1, 2, 2, 1 };

      ListNode head = BuildLinkedList(input);

      bool output = IsPalindrome(head);

      Console.WriteLine(output);
   }
   public static bool IsPalindrome(ListNode head)
   {
      List<int> values = new List<int>();
      while (head != null)
      {
         values.Add(head.val);
         head = head.next;
      }

      int l = 0, r = values.Count - 1;

      while (l < r)
      {
         if (values[l++] != values[r--]) return false;
      }

      return true;
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
}
