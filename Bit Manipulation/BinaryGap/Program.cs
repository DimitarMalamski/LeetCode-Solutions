// Problem 868. Binary Gap
// Link https://leetcode.com/problems/binary-gap/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int n = 22;
    int output = BinaryGap(n);
    Console.WriteLine(output);
  }
  public static int BinaryGap(int n)
  {
    int maxDistance = 0;
    int lastPosition = -1;
    int currentPosition = 0;

    while (n > 0)
    {
      if ((n & 1) == 1)
      {
        if (lastPosition != -1)
        {
          maxDistance = Math.Max(maxDistance, currentPosition - lastPosition);
        }

        lastPosition = currentPosition;
      }

      currentPosition++;
      n >>= 1;
    }

    return maxDistance;
  }
}
