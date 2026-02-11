// Problem 509. Fibonacci Number
// Link https://leetcode.com/problems/fibonacci-number/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 4;
    int output = FibOptimized(n);
    Console.WriteLine(output);
  }
  public static int Fib(int n)
  {
    if (n < 2) return n;

    return Fib(n - 1) + Fib(n - 2);
  }
  public static int FibOptimized(int n)
  {
    if (n < 2) return n;

    int prev2 = 0;
    int prev1 = 1;

    for (int i = 2; i <= n; i++)
    {
      int current = prev1 + prev2;
      prev2 = prev1;
      prev1 = current;
    }

    return prev1;
  }
}