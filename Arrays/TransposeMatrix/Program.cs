// Problem 867. Transpose Matrix
// Link https://leetcode.com/problems/transpose-matrix/description/
// Difficulty: Easy
class Solution
{
  static void Main(string[] args)
  {
    int[][] matrix = new int[][] {
      new int[] {1, 2, 3},
      new int[] {4, 5, 6}
    };

    Solution sol = new Solution();
    int[][] transposed = sol.Transpose(matrix);

    Console.WriteLine("Transposed Matrix:");
    for (int i = 0; i < transposed.Length; i++)
    {
      for (int j = 0; j < transposed[i].Length; j++)
      {
        Console.Write(transposed[i][j] + " ");
      }
      Console.WriteLine();
    }
  }
  public int[][] Transpose(int[][] matrix)
  {
    int m = matrix.Length;
    int n = matrix[0].Length;

    int[][] result = new int[n][];

    for (int i = 0; i < n; i++)
    {
      result[i] = new int[m];
    }

    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[j][i] = matrix[i][j];
      }
    }

    return result;
  }
}
