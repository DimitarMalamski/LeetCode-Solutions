// Problem 509. Fibonacci Number
// Link https://leetcode.com/problems/fibonacci-number/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 4;
    int output = Fib(n);
    Console.WriteLine(output);
  }
  public static int Fib(int n)
  {
    if (n < 2) return n;

    return Fib(n - 1) + Fib(n - 2);
  }
}