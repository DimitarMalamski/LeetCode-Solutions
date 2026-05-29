// Problem 1137. N-th Tribonacci Number
// Link https://leetcode.com/problems/n-th-tribonacci-number/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 25;
    int output = Tribonacci(n);
    Console.WriteLine(output);
  }
  public static int Tribonacci(int n)
  {
    if (n == 0) return 0;
    if (n == 1 || n == 2) return 1;

    int t0 = 0;
    int t1 = 1;
    int t2 = 1;

    for (int i = 3; i <= n; i++)
    {
      int next = t0 + t1 + t2;

      t0 = t1;
      t1 = t2;
      t2 = next;
    }

    return t2;
  }
}