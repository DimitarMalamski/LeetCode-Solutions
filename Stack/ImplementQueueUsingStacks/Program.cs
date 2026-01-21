// Problem 232. Implement Queue using Stacks
// Link https://leetcode.com/problems/implement-queue-using-stacks/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      MyQueue myQueue = new MyQueue();

      myQueue.Push(1);
      myQueue.Push(2);

      Console.WriteLine(myQueue.Peek());
      Console.WriteLine(myQueue.Pop());
      Console.WriteLine(myQueue.Empty());
   }

   public class MyQueue
   {
      private Stack<int> inStack;
      private Stack<int> outStack;

      public MyQueue()
      {
         inStack = new Stack<int>();
         outStack = new Stack<int>();
      }

      public void Push(int x)
      {
         inStack.Push(x);
      }

      public int Pop()
      {
         MoveIfNeeded();
         return outStack.Pop();
      }

      public int Peek()
      {
         MoveIfNeeded();
         return outStack.Peek();
      }

      public bool Empty()
      {
         return inStack.Count == 0 && outStack.Count == 0;
      }

      private void MoveIfNeeded()
      {
         if (outStack.Count == 0)
         {
            while (inStack.Count > 0)
            {
               outStack.Push(inStack.Pop());
            }
         }
      }
   }
}
