// Problem 506. Relative Ranks
// Link https://leetcode.com/problems/relative-ranks/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int num = 28;
    bool output = CheckPerfectNumber(num);
    Console.WriteLine(output);
  }
  public static bool CheckPerfectNumber(int num)
  {
    if (num <= 1) return false;

    int sum = 1;

    for (int i = 2; i * i <= num; i++)
    {
      if (num % i == 0)
      {
        sum += i;

        int other = num / i;
        if (other != i)
        {
          sum += other;
        }
      }
    }

    return sum == num;
  }
}
