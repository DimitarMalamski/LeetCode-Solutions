// Problem 1252. Cells with Odd Values in a Matrix
// Link https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int m = 2;
    int n = 3;

    int[][] indices = {
      new int[] {  0,1 },
      new int[] { 1,1}
    };

    int output = OddCells(m, n, indices);
    Console.WriteLine(output);
  }
  public static int OddCells(int m, int n, int[][] indices)
  {
    bool[] oddRows = new bool[m];
    bool[] oddCols = new bool[n];

    foreach (int[] index in indices)
    {
      int row = index[0];
      int col = index[1];

      oddRows[row] = !oddRows[row];
      oddCols[col] = !oddCols[col];
    }

    int oddRowCount = 0;
    int oddColCount = 0;

    foreach (bool rowIsOdd in oddRows)
    {
      if (rowIsOdd)
      {
        oddRowCount++;
      }
    }

    foreach (bool colIsOdd in oddCols)
    {
      if (colIsOdd)
      {
        oddColCount++;
      }
    }

    int result = 0;

    result += oddRowCount * (n - oddColCount);
    result += (m - oddRowCount) * oddColCount;

    return result;
  }
}
