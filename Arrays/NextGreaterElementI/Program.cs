// Problem 496. Next Greater Element I
// Link https://leetcode.com/problems/next-greater-element-i/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums1 = { 4, 1, 2 };
    int[] nums2 = { 1, 3, 4, 2 };

    int[] output = NextGreaterElement(nums1, nums2);
    Console.WriteLine(string.Join(",", output));
  }
  public static int[] NextGreaterElement(int[] nums1, int[] nums2)
  {
    Dictionary<int, int> nextGreater = new Dictionary<int, int>();
    Stack<int> stack = new Stack<int>();

    foreach (int num in nums2)
    {
      while (stack.Count > 0 && num > stack.Peek())
      {
        int smaller = stack.Pop();
        nextGreater[smaller] = num;
      }

      stack.Push(num);
    }

    while (stack.Count > 0)
    {
      nextGreater[stack.Pop()] = -1;
    }

    int[] result = new int[nums1.Length];
    for (int i = 0; i < nums1.Length; i++)
    {
      result[i] = nextGreater[nums1[i]];
    }

    return result;
  }
}
