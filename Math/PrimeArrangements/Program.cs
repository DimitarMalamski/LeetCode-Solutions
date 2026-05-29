// Problem 1175. Prime Arrangements
// Link https://leetcode.com/problems/prime-arrangements/description/
// Difficulty: Easy
class Solution
{
  private const long MOD = 1000000007;
  static void Main(string[] args)
  {
    int n = 100;
    int output = NumPrimeArrangements(n);
    Console.WriteLine(output);
  }
  public static int NumPrimeArrangements(int n)
  {
    int primeCount = 0;

    for (int i = 1; i <= n; i++)
    {
      if (IsPrime(i)) primeCount++;
    }

    int nonPrimeCount = n - primeCount;

    long result = Factorial(primeCount) * Factorial(nonPrimeCount);
    result %= MOD;

    return (int)result;
  }

  private static bool IsPrime(int number)
  {
    if (number < 2)
    {
      return false;
    }

    for (int i = 2; i * i <= number; i++)
    {
      if (number % i == 0)
      {
        return false;
      }
    }

    return true;
  }

  private static long Factorial(int number)
  {
    long result = 1;

    for (int i = 2; i <= number; i++)
    {
      result *= i;
      result %= MOD;
    }

    return result;
  }
}
