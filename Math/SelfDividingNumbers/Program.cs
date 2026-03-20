// Problem 728. Self Dividing Numbers
// Link https://leetcode.com/problems/self-dividing-numbers/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int left = 1, right = 22;
    List<int> output = SelfDividingNumbers(left, right);
    Console.WriteLine(string.Join(", ", output));
  }
  public static List<int> SelfDividingNumbers(int left, int right)
  {
    List<int> result = new List<int>();

    for (int i = left; i <= right; i++)
    {
      if (IsSelfDivifing(i)) result.Add(i);
    }

    return result;
  }
  private static bool IsSelfDivifing(int number)
  {
    int temp = number;

    while (number > 0)
    {
      int digit = number % 10;
      if (digit == 0 || temp % digit != 0) return false;
      number /= 10;
    }

    return true;
  }
}
