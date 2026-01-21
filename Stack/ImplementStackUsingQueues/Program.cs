// Problem 225. Implement Stack using Queues
// Link https://leetcode.com/problems/implement-stack-using-queues/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      MyStack stack = new MyStack();
      stack.Push(1);
      Console.WriteLine(string.Join(", ", stack));
      stack.Push(2);
      Console.WriteLine(string.Join(", ", stack));

      Console.WriteLine(stack.Top());
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Empty());
   }

   class MyStack
   {
      Queue<int> q1 = new Queue<int>();
      Queue<int> q2 = new Queue<int>();

      public void Push(int x)
      {
         q2.Enqueue(x);

         while (q1.Count > 0)
         {
            q2.Enqueue(q1.Dequeue());
         }

         Queue<int> temp = q1;
         q1 = q2;
         q2 = temp;
      }

      public int Pop()
      {
         return q1.Dequeue();
      }

      public int Top()
      {
         return q1.Peek();
      }

      public bool Empty()
      {
         return q1.Count == 0;
      }
   }
}
