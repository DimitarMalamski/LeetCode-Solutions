// Problem 598. Range Addition II
// Link https://leetcode.com/problems/range-addition-ii/description/
// Difficulty: Easy
class Solutio
{
  static void Main(string[] args)
  {
    int m = 3;
    int n = 3;

    int[][] ops = new int[][] {
      new int[] { 2,2 },
      new int[] { 3,3 }
    };

    int output = MaxCount(m, n, ops);

    Console.WriteLine(output);
  }
  public static int MaxCount(int m, int n, int[][] ops)
  {
    if (ops.Length == 0) return m * n;

    int minRow = m;
    int minCol = n;

    foreach (var op in ops)
    {
      minRow = Math.Min(minRow, op[0]);
      minCol = Math.Min(minCol, op[1]);
    }

    return minRow * minCol;
  }
}
