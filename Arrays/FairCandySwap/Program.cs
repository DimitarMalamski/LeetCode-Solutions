// Problem 888. Fair Candy Swap
// Link https://leetcode.com/problems/fair-candy-swap/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] aliceSizes = { 1, 1, };
    int[] bobSizes = { 2, 2 };
    int[] output = FairCandySwap(aliceSizes, bobSizes);
    Console.WriteLine(string.Join(", ", output));
  }
  public static int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
  {
    int sumA = 0;
    int sumB = 0;

    foreach (int a in aliceSizes)
    {
      sumA += a;
    }

    foreach (int b in bobSizes)
    {
      sumB += b;
    }

    int diff = (sumB - sumA) / 2;

    HashSet<int> bobSet = new HashSet<int>(bobSizes);

    foreach (int a in aliceSizes)
    {
      int b = a + diff;

      if (bobSet.Contains(b))
      {
        return new int[] { a, b };
      }
    }

    return new int[0];
  }
}
