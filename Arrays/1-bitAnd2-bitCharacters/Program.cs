// Problem 717. 1-bit and 2-bit Characters
// Link https://leetcode.com/problems/1-bit-and-2-bit-characters/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] bits = { 1, 0, 0 };
    bool output = IsOneBitCharacter(bits);
    Console.WriteLine(output);
  }
  public static bool IsOneBitCharacter(int[] bits)
  {
    int i = 0;

    while (i < bits.Length - 1)
    {
      if (bits[i] == 1)
      {
        i += 2;
      }
      else
      {
        i += 1;
      }
    }

    return i == bits.Length - 1;
  }
}
