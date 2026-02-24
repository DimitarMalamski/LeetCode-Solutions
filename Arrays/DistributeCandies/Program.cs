// Problem 575. Distribute Candies
// Link https://leetcode.com/problems/distribute-candies/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] candyType = { 1, 1, 2, 2, 3, 3 };
    int output = DistributeCandies(candyType);
    Console.WriteLine(output);
  }
  public static int DistributeCandies(int[] candyType)
  {
    HashSet<int> uniqueTypes = new HashSet<int>(candyType);
    int maxAllowed = candyType.Length / 2;

    return Math.Min(uniqueTypes.Count, maxAllowed);
  }
}