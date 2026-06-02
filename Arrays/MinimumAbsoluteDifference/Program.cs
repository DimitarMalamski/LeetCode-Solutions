// Problem 1200. Minimum Absolute Difference
// Link https://leetcode.com/problems/minimum-absolute-difference/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[] arr = { 4, 2, 1, 3 };
    IList<IList<int>> output = MinimumAbsDifference(arr);
    foreach (List<int> list in output)
    {
      Console.WriteLine(string.Join(", ", list));
    }
  }
  public static IList<IList<int>> MinimumAbsDifference(int[] arr)
  {
    Array.Sort(arr);

    int minDiff = int.MaxValue;
    var result = new List<IList<int>>();

    for (int i = 1; i < arr.Length; i++)
    {
        int diff = arr[i] - arr[i - 1];

        if (diff < minDiff)
        {
          minDiff = diff;
          result.Clear();
          result.Add(new List<int> { arr[i - 1], arr[i] });
        }
        else if (diff == minDiff)
        {
          result.Add(new List<int> { arr[i - 1], arr[i] });
        }
    }

    return result;
  }
}
