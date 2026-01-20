// Problem 83. Remove Duplicates from Sorted List
// Link https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 1, 1, 2, 3, 3 };
      ListNode head = BuildLinkedList(input);
      ListNode result = DeleteDuplicates(head);
      PrintList(result);
   }
   public static ListNode? DeleteDuplicates(ListNode head)
   {
      ListNode current = head;

      while (current != null && current.next != null)
      {
         if (current.val == current.next.val)
         {
            current.next = current.next.next;
         }
         else
         {
            current = current.next;
         }
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
}
