// Problem 495. Teemo Attacking
// Link https://leetcode.com/problems/teemo-attacking/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] timeSeries = { 1, 4 };
    int duration = 2;
    int output = FindPoisonedDuration(timeSeries, duration);
    Console.WriteLine(output);
  }
  public static int FindPoisonedDuration(int[] timeSeries, int duration)
  {
    if (timeSeries.Length == 0) return 0;

    int total = 0;

    for (int i = 0; i < timeSeries.Length - 1; i++)
    {
      int gap = timeSeries[i + 1] - timeSeries[i];
      total += Math.Min(duration, gap);
    }

    total += duration;

    return total;
  }
}
