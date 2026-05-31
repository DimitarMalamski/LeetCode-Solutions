// Problem 1184. Distance Between Bus Stops
// Link https://leetcode.com/problems/distance-between-bus-stops/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] distance = { 1, 2, 3, 4 };
    int start = 0;
    int destination = 1;
    int output = DistanceBetweenBusStops(distance, start, destination);
    Console.WriteLine(output);
  }
  public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
  {
    if (start > destination)
    {
      int temp = start;
      start = destination;
      destination = temp;
    }

    int clockwise = 0;
    int total = 0;

    for (int i = 0; i < distance.Length; i++)
    {
      total += distance[i];

      if (i >= start && i < destination)
      {
        clockwise += distance[i];
      }
    }

    int counterClockwise = total - clockwise;

    return Math.Min(clockwise, counterClockwise);
  }
}
