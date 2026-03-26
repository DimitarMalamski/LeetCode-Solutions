// Problem 762. Prime Number of Set Bits in Binary Representation
// Link https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int left = 6, right = 10;
    int output = CountPrimeSetBits(left, right);
    Console.WriteLine(output);
  }
  public static int CountPrimeSetBits(int left, int right)
  {
    int count = 0;

    for (int num = left; num <= right; num++)
    {
      int setBits = CountBits(num);

      if (IsPrime(setBits))
      {
        count++;
      }
    }

    return count;
  }

  private static int CountBits(int num)
  {
    int count = 0;

    while (num > 0)
    {
      count += num & 1;
      num >>= 1;
    }

    return count;
  }
  private static bool IsPrime(int n)
  {
    if (n < 2) return false;

    for (int i = 2; i * i <= n; i++)
    {
      if (n % i == 0) return false;
    }

    return true;
  }
}
