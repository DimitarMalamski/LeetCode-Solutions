// Problem 1018. Binary Prefix Divisible By 5
// Link https://leetcode.com/problems/binary-prefix-divisible-by-5/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 0, 1, 1 };
    List<bool> output = PrefixesDivBy5(nums);
    Console.WriteLine(string.Join(",", output));
  }
  public static List<bool> PrefixesDivBy5(int[] nums)
  {
    List<bool> answer = new List<bool>();
    int reminder = 0;

    foreach (int bit in nums)
    {
      reminder = (reminder * 2 + bit) % 5;
      answer.Add(reminder == 0);
    }

    return answer;
  }
}