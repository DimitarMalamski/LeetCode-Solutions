// Problem 746. Min Cost Climbing Stairs
// Link https://leetcode.com/problems/min-cost-climbing-stairs/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] cost = { 10, 15, 20 };
    int output = MinCostClimbingStairs(cost);
    Console.WriteLine(output);
  }
  public static int MinCostClimbingStairs(int[] cost)
  {
    int n = cost.Length;
    int[] dp = new int[n];

    dp[0] = cost[0];
    dp[1] = cost[1];

    for (int i = 2; i < n; i++)
    {
      dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
    }

    return Math.Min(dp[n - 1], dp[n - 2]);
  } 
}
