// Problem 203. Remove Linked List Elements
// Link https://leetcode.com/problems/remove-linked-list-elements/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 1, 2, 6, 3, 4, 5, 6 };
      ListNode head = BuildLinkedList(input);
      int val = 6;
      ListNode result = RemoveElements(head, val);
      PrintList(result);
   }
   public static ListNode RemoveElements(ListNode head, int val)
   {
      ListNode dummy = new ListNode(0, head);
      ListNode current = dummy;

      while (current.next != null)
      {
         if (current.next.val == val)
         {
            current.next = current.next.next;
         }
         else
         {
            current = current.next;
         }
      }

      return dummy.next;
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
