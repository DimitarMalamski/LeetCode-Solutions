// Problem 1281. Subtract the Product and Sum of Digits of an Integer
// Link https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 234;
    int output = SubtractProductAndSum(n);
    Console.WriteLine(output);
  }
  public static int SubtractProductAndSum(int n)
  {
    int product = 1;
    int sum = 0;

    while (n > 0)
    {
      int digit = n % 10;

      product *= digit;
      sum += digit;

      n /= 10;
    }

    return product - sum;
  }
}
