// Problem 693. Binary Number with Alternating Bits
// Link https://leetcode.com/problems/binary-number-with-alternating-bits/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 5;
    bool output = HasAlternatingBits(n);
    Console.WriteLine(output);
  }
  public static bool HasAlternatingBits(int n)
  {
    int lastBit = n & 1;

    n >>= 1;

    while (n > 0)
    {
      int currentBit = n & 1;

      if (currentBit == lastBit) return false;

      lastBit = currentBit;
      n >>= 1;
    }

    return true;
  }
}
