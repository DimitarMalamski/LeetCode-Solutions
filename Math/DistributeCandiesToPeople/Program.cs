// Problem 1103. Distribute Candies to People
// Link https://leetcode.com/problems/distribute-candies-to-people/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int candies = 7, num_people = 4;
    int[] output = DistributeCandies(candies, num_people);
    Console.WriteLine(string.Join(",", output));
  }
  public static int[] DistributeCandies(int candies, int num_people)
  {
    int[] result = new int[num_people];

    int give = 1;
    int person = 0;

    while (candies > 0)
    {
      int amount = Math.Min(give, candies);

      result[person] += amount;
      candies -= amount;

      give++;
      person = (person + 1) % num_people;
    }

    return result;
  }
}
