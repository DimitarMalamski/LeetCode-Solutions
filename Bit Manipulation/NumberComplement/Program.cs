// Problem 476. Number Complement
// Link https://leetcode.com/problems/number-complement/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int num = 5;
    int output = FindComplement(num);
    Console.WriteLine(output);
  }
  public static int FindComplement(int num)
  {
    long mask = 1;

    while (mask <= num)
    {
      mask <<= 1;
    }

    return (int)((mask - 1) ^ num);
  }
}

