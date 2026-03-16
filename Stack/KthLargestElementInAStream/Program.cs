// Problem 703. Kth Largest Element in a Stream
// Link https://leetcode.com/problems/kth-largest-element-in-a-stream/description/
// Difficulty: Easy
using System;
using System.Collections.Generic;
class Solution
{
  static void Main(string[] args)
  {
    KthLargest kthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });

    Console.WriteLine(kthLargest.Add(3));
    Console.WriteLine(kthLargest.Add(5));
    Console.WriteLine(kthLargest.Add(10));
    Console.WriteLine(kthLargest.Add(9));
    Console.WriteLine(kthLargest.Add(4));
  }
  public class KthLargest
  {
    private int k;
    private PriorityQueue<int, int> heap;

    public KthLargest(int k, int[] nums)
    {
      this.k = k;
      heap = new PriorityQueue<int, int>();

      foreach (int num in nums)
      {
        Add(num);
      }
    }

    public int Add(int val)
    {
      heap.Enqueue(val, val);

      if (heap.Count > k)
      {
        heap.Dequeue();
      }

      return heap.Peek();
    }
  }
}
