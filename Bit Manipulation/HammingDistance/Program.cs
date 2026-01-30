// Problem 461. Hamming Distance
// Link https://leetcode.com/problems/hamming-distance/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int x = 1, y = 4;
    int output = HammingDistance(x, y);
    Console.WriteLine(output);
  }
  public static int HammingDistance(int x, int y)
  {
    int xor = x ^ y;
    int count = 0;

    while (xor != 0)
    {
      count += xor & 1;
      xor >>= 1;
    }

    return count;
  }
}
