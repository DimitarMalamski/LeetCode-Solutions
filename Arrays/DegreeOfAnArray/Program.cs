// Problem 697. Degree of an Array
// Link https://leetcode.com/problems/degree-of-an-array/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] nums = { 1, 2, 2, 3, 1 };
    int output = FindShortestSubArray(nums);
    Console.WriteLine(output);
  }
  public static int FindShortestSubArray(int[] nums)
  {
    Dictionary<int, int> count = new Dictionary<int, int>();
    Dictionary<int, int> first = new Dictionary<int, int>();
    Dictionary<int, int> last = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
      int num = nums[i];

      if (!first.ContainsKey(num))
      {
        first[num] = i;
      }

      last[num] = i;

      if (count.ContainsKey(num))
      {
        count[num]++;
      }
      else
      {
        count[num] = 1;
      }
    }

    int degree = count.Values.Max();
    int minLength = nums.Length;

    foreach (var num in count.Keys)
    {
      if (count[num] == degree)
      {
        int length = last[num] - first[num] + 1;
        minLength = Math.Min(minLength, length);
      }
    }

    return minLength;
  }
}
