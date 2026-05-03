// Problem 944. Delete Columns to Make Sorted
// Link https://leetcode.com/problems/delete-columns-to-make-sorted/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    string[] strs = { "cba", "daf", "ghi" };
    int output = MinDeletionSize(strs);
    Console.WriteLine(output);
  }
  public static int MinDeletionSize(string[] strs)
  {
    int deleteCount = 0;

    int rowCount = strs.Length;
    int columnCount = strs[0].Length;

    for (int col = 0; col < columnCount; col++)
    {
      for (int row = 1; row < rowCount; row++)
      {
        if (strs[row][col] < strs[row - 1][col])
        {
          deleteCount++;
          break;
        }
      }
    }

    return deleteCount;
  }
}
